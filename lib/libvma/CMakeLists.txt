cmake_minimum_required(VERSION 3.20)
project(VulkanMemoryAllocator)

add_library(VulkanMemoryAllocator SHARED ../VulkanMemoryAllocator/include/vk_mem_alloc.h vma.cpp)
target_include_directories(VulkanMemoryAllocator PRIVATE ../VulkanMemoryAllocator/include)

find_package(Vulkan REQUIRED)
target_link_libraries(${PROJECT_NAME} PUBLIC ${Vulkan_LIBRARIES})
target_include_directories(${PROJECT_NAME} PUBLIC ${Vulkan_INCLUDE_DIRS})