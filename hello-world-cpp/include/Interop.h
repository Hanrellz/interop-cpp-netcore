#ifdef __cplusplus
extern "C" {
#endif

#ifdef _WIN32
#  ifdef MODULE_API_EXPORTS
#    define MODULE_API __declspec(dllexport)
#  else
#    define MODULE_API __declspec(dllimport)
#  endif
#else
#  define MODULE_API
#endif

MODULE_API int RetornoInt(int x);
MODULE_API float RetornoFloat(float x);
MODULE_API double RetornoDouble(double x);
MODULE_API bool RetornoBool(bool x);
MODULE_API void ImprimePalavra(char* palavra);

#ifdef __cplusplus
}
#endif