// See https://aka.ms/new-console-template for more information
using CSHARP_LUA;

#region 測試NLua
var luaExample = new LuaExample();
luaExample.RunLuaScript();
luaExample.RunLuaRegisterFunction();
int[] result = luaExample.RunLuaResult();
#endregion 測試NLua
