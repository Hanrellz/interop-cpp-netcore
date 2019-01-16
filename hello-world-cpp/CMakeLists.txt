cmake_minimum_required(VERSION 3.7)
project(hello_world_cpp)

set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib)
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib)
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin)

set(CMAKE_CXX_STANDARD 14)
set(WARNINGS "-Wall -Wextra")#set(WARNINGS "-w")
set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} ${WARNINGS}")

include_directories("${PROJECT_SOURCE_DIR}/include")

add_subdirectory(src)

install(DIRECTORY build/lib/ DESTINATION /usr/lib/)