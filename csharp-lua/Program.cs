// See https://aka.ms/new-console-template for more information
using CSHARP_LUA;

#region 測試NLua
// 初始化 Lua 測試範例類別
var luaExample = new LuaExample();

// 1. 測試：直接執行 Lua 字串指令
luaExample.RunLuaScript();

// 2. 測試：將 C# 方法註冊到 Lua 中，並讓 Lua 呼叫該方法
luaExample.RunLuaRegisterFunction();

// 3. 測試：從 Lua 執行結果中獲取傳回值並轉為 C# 陣列
int[] result = luaExample.RunLuaResult();
#endregion 測試NLua
