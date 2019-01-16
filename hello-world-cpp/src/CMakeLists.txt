set(LIBS)

set(SOURCE_FILES
        Interop.cpp)

add_library(hello_world_cpp SHARED ${SOURCE_FILES})
target_link_libraries(hello_world_cpp ${LIBS})