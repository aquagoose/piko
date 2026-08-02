#!/bin/bash

if [ $# -lt 1 ]; then
    echo "Please give a workflow OS: supported values: windows-latest, ubuntu-latest, macos-latest"
    exit 2
fi

WORKFLOW_OS=$1

rm -rf build
mkdir -p build

echo "Building SDL3"
mkdir -p SDL/build
pushd SDL/build

echo "    Configuring CMake..."
cmake .. -DCMAKE_BUILD_TYPE=Release || exit 1
echo "    Building..."
cmake --build . --config Release || exit 1
echo "    Done."

popd
echo "SDL3 done."

echo "Building VMA"
mkdir -p libvma/build
pushd libvma/build

echo "    Configuring CMake..."
cmake .. -DCMAKE_BUILD_TYPE=Release || exit 1
echo "    Building..."
cmake --build . --config Release || exit 1
echo "    Done."

popd
echo "VMA done."

echo "Copying dlls to output"

RUNTIME=""
SDL3_DLLNAME=""
VMA_DLLNAME=""

case $WORKFLOW_OS in
    windows-latest)
	RUNTIME="win-x64"
	SDL3_DLLNAME="Release/SDL3.dll"
	VMA_DLLNAME="Release/VulkanMemoryAllocator.dll"
        ;;
    ubuntu-latest)
        RUNTIME="linux-x64"
	SDL3_DLLNAME="libSDL3.so"
	VMA_DLLNAME="libVulkanMemoryAllocator.so"
	;;
    macos-latest)
        RUNTIME="osx-arm64"
	SDL3_DLLNAME="libSDL3.dylib"
	VMA_DLLNAME="libVulkanMemoryAllocator.dylib"
	;;
esac

echo "Runtime: $RUNTIME"
echo "SDL3 DLL Name: $SDL3_DLLNAME"
echo "VMA DLL Name: $VMA_DLLNAME"

echo "Copying SDL3"
SDL3_OUTDIR=build/SDL3/runtimes/$RUNTIME/native
echo "    Directory: $SDL3_OUTDIR"
mkdir -p $SDL3_OUTDIR
cp -L SDL/build/$SDL3_DLLNAME $SDL3_OUTDIR

echo "Copying VMA"
VMA_OUTDIR=build/VMA/runtimes/$RUNTIME/native
echo "    Directory: $VMA_OUTDIR"
mkdir -p $VMA_OUTDIR
cp -L libvma/build/$VMA_DLLNAME $VMA_OUTDIR
