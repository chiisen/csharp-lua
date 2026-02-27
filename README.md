# 🚀 csharp-lua

C# 與 Lua 的混合編程測試 🛠️✨

## 📋 專案簡介
本專案是一個簡單的測試環境，用於探索 **C# (.NET 10)** 與 **Lua** 之間的交互操作。透過 **NLua** 套件，我們可以在 C# 中執行 Lua 腳本、註冊 C# 方法給 Lua 呼叫以及獲取返回值。

---

## 🛠️ 技術棧
- **Runtime**: .NET 10.0 SDK
- **Language**: C# 12
- **Lua Library**: [NLua](https://github.com/nlua/NLua) (v1.7.3)

---

## 🚀 如何執行

### 1. 確認環境
確保您的開發環境已安裝 **.NET 10 SDK**。
```bash
dotnet --version
```

### 2. 下載專案
```bash
git clone https://github.com/chiisen/csharp-lua.git
cd csharp-lua/csharp-lua
```

### 3. 還原套件並執行
```bash
dotnet run --project csharp-lua
```

---

## ✨ 核心功能測試
- [x] **執行簡單 Lua 腳本**: `lua.DoString("print('Hello, World!')")`
- [x] **註冊 C# 方法**: 將 C# 的 `SayHello` 方法註冊到 Lua 環境中供其呼叫。
- [x] **多重傳回值處理**: 從 Lua 腳本獲取多個傳回值並轉化為 C# 的陣列。

---

## 🔄 同步說明
專案包含一個 `setup_git_sync.ps1` 腳本，用於設定多個遠端倉庫同步備份：
```powershell
./setup_git_sync.ps1
```
