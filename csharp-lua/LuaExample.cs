using NLua;

namespace CSHARP_LUA
{
    /// <summary>
    /// 展示 C# 與 Lua 互操作性的範例類別
    /// </summary>
    public class LuaExample
    {
        /// <summary>
        /// 測試在 C# 中直接執行簡單的 Lua 腳本
        /// </summary>
        public void RunLuaScript()
        {
            // 建立 Lua 解釋器實例
            using (var lua = new Lua())
            {
                // DoString 用於執行 Lua 程式碼字串
                lua.DoString("print('Hello, World!')");
            }
        }

        /// <summary>
        /// 測試將 C# 的方法註冊到 Lua 環境中，以便在 Lua 腳本裡呼叫
        /// </summary>
        public void RunLuaRegisterFunction()
        {
            using (var lua = new Lua())
            {
                // 註冊目前實例的 SayHello 方法，並在 Lua 中命名為 "SayHello"
                lua.RegisterFunction("SayHello", this, GetType().GetMethod("SayHello"));
                
                // 在 Lua 中呼叫剛剛註冊的 C# 方法
                lua.DoString("SayHello()");
            }
        }

        /// <summary>
        /// C# 原生方法，待會會被註冊供 Lua 呼叫
        /// </summary>
        public void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// 測試從 Lua 腳本獲取多個傳回值，並將其轉換為 C# 的強型別陣列
        /// </summary>
        /// <returns>包含傳回數字的整數陣列</returns>
        public int[] RunLuaResult()
        {
            using (var lua = new Lua())
            {
                // Lua 可以一次傳回多個值，NLua 會將其讀取為 object[]
                object[] result = lua.DoString("return 1, 2, 3");
                
                // 遍歷並印出 Lua 傳回的原始物件
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                
                // 將 object[] 轉換為 int[] (由於 Lua 數字預設為 Double/Int64，需使用 Convert.ToInt32)
                int[] intArray = result.Select(Convert.ToInt32).ToArray();
                return intArray;
            }
        }
    }
}
