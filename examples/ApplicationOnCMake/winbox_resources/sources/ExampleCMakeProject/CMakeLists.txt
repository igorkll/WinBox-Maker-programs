cmake_minimum_required(VERSION 3.10)
project(ExampleCMakeProject C CXX)

set(CMAKE_C_STANDARD 23)
set(CMAKE_CXX_STANDARD 23)

file(GLOB_RECURSE SOURCES src/*.c src/*.cpp)
add_executable(ExampleCMakeProject WIN32 ${SOURCES})
target_link_libraries(ExampleCMakeProject user32 gdi32)
