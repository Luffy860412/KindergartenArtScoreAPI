# KindergartenArtScoreAPI (幼兒園美術成績管理系統 API) - V3.0 UI版本

**簡介**

`KindergartenArtScoreAPI` 是一個基於 ASP.NET Core Web API 的後端服務，專為幼兒園美術評分系統而設計。V3.0 版本在保留完整 CRUD API 功能的同時，全面升級了前端介面，採用現代化前端技術和設計，為使用者提供更流暢、直觀且美觀的操作體驗。

---

**主要功能 (V3.0 更新內容)**

* **✅ 完整 CRUD API 後端：**  
  提供學生美術評分資料的 **新增 (Create)、讀取 (Read)、更新 (Update)、刪除 (Delete)** API 端點，方便開發者進行系統整合與資料管理。

* **✨ 全新前端使用者介面 (UI)：**  
  - 使用 **React 18** 與 **TypeScript** 打造現代化單頁應用程式。  
  - 透過 **Tailwind CSS** 實現優雅的樣式設計，結合 **Lucide React** 提供豐富的圖標資源。  
  - 利用 **React Hooks** 管理狀態，實現高效的數據流處理。  
  - 以 **Vite** 為開發與構建工具，大幅提升開發效能與編譯速度。  
  - 設計採用漸變色與玻璃態 (Glassmorphism) 效果、響應式佈局、動態顏色反饋以及模態框交互，帶來更佳的使用體驗。

* **🎨 學生資料展示：**  
  以表格形式清楚呈現所有學生的基本資料（姓名、班級）與美術評分，方便使用者瀏覽與查詢。

* **➕ 新增學生功能：**  
  提供友善的表單介面，讓使用者能夠輕鬆將新學生資料加入系統。

* **✏️ 編輯與更新：**  
  支援基本編輯功能，允許使用者隨時修改現有學生資料。

* **❌ 刪除學生功能：**  
  提供簡易的刪除操作，讓使用者能夠移除不再需要的資料。

* **🐍 API 輸出格式優化：**  
  自動將 JSON 輸出中的 KEY 名稱從 PascalCase 轉換為 `snake_case`（例如：`className` 轉為 `class_name`），更符合 JavaScript 與 Web 開發慣例。

* **🔗 API 整合層：**  
  - 使用 **axios** 處理 HTTP 請求，建立統一的 API 客戶端。  
  - 封裝所有 CRUD 操作，提供一致且簡潔的調用介面。  
  - 增加載入狀態顯示、錯誤處理以及操作成功/失敗提示，並優化數據刷新邏輯，確保系統穩定與即時回饋。

* **資料儲存與種子資料：**  
  採用輕量級 **SQLite** 資料庫進行資料儲存，並於初始化時自動填充種子資料，方便快速測試與展示。

* **RESTful API 設計：**  
  除了全新前端介面外，開發者仍可直接透過 RESTful API 端點進行資料操作。

* **使用 .NET 7 開發：**  
  基於最新的 .NET 7 平台構建，具備出色的效能與跨平台能力。

---

**技術棧**

* **後端 API:**  
  - [.NET 7](https://dotnet.microsoft.com/zh-tw/download/dotnet/7.0)  
  - [ASP.NET Core Web API](https://learn.microsoft.com/zh-tw/aspnet/core/web-api/?view=aspnetcore-7.0)

* **前端 UI:**  
  - **React 18 + TypeScript**  
  - **Tailwind CSS**（樣式設計）  
  - **Lucide React**（圖標庫）  
  - **React Hooks**（狀態管理）  
  - **Vite**（開發與構建工具）

* **ORM:**  
  [Entity Framework Core (EF Core)](https://learn.microsoft.com/zh-tw/ef/core/)

* **資料庫:**  
  [SQLite](https://www.sqlite.org/index.html)

* **假資料產生:**  
  [Bogus](https://github.com/bchavez/Bogus)

* **HTTP 客戶端:**  
  [axios](https://axios-http.com/)

* **開發工具:**  
  [Visual Studio Code](https://code.visualstudio.com/) 或其他 .NET 開發工具

---

**環境需求 (Prerequisites)**

在執行此專案之前，請確保您的開發環境已安裝以下組件：

* **[.NET SDK 7.0](https://dotnet.microsoft.com/zh-tw/download/dotnet/7.0):**  
  下載並安裝 .NET SDK 7.0 或更高版本，完成後在終端機中執行 `dotnet --version` 以確認安裝成功。

* **[Visual Studio Code (建議)](https://code.visualstudio.com/):**  
  建議搭配 [C# 擴充套件](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) 使用，提升開發效率。

* **[SQLite 資料庫瀏覽器 (DB Browser for SQLite) (建議)](https://sqlitebrowser.org/):**  
  方便直接檢視與管理 SQLite 資料庫檔案。

---

**如何執行專案 (Getting Started)**

本專案由前後端兩部分組成，請依照以下步驟分別啟動各自的服務：

**從 GitHub 克隆專案程式碼:**

  打開終端機或命令提示字元，切換到您希望存放專案程式碼的目錄，然後執行以下 `git clone` 命令：

  ```bash
  git clone [https://github.com/](https://github.com/)Luffy860412/KindergartenArtScoreAPI.git
  ```

### 前端部分

1. **切換到前端資料夾：**  
   ```bash
   cd Frontend
   ```

2.  **安裝依賴項:**

    ```bash
    npm install
    ```

3.  **啟動前端開發伺服器:**

    ```bash
    npm run dev
    ```
    
**前端渲染 UI 將於瀏覽器中開啟:** http://localhost:5173/

### 後端部分

1. **切換到後端資料夾：**  
   ```bash
   cd KindergartenArtScoreAPI
   ```

2.  **還原 NuGet 套件 (建議):**

    ```bash
    dotnet restore
    ```

3.  **更新資料庫 (建立資料庫並填充種子資料)：**

    ```bash
    dotnet ef database update
    ```
    
4.  **啟動後端 API 應用程式：**

    ```bash
    dotnet run
    ```
		啟動後，您將在終端機中看到類似 Now listening on: http://localhost:5000 的訊息。
		
### 存取方式（共三種）

    *   **方式一： 使用前端渲染而成的網頁操作 (全新 V3.0 功能 - 推薦使用者使用):**

        *   **開啟網頁瀏覽器，在網址列輸入以下網址並訪問:**

            ```
            http://localhost:5173/
            ```

        *   **您將看到 KindergartenArtScoreAPI 的網頁使用者介面。**  您可以在網頁介面上瀏覽學生列表、新增學生資料、編輯和刪除學生資料 (V3.0 版本)。  **透過網頁介面操作，您可以更直觀、更便捷地使用 KindergartenArtScoreAPI 系統的功能。**
    
    *   **方式二： 使用後端渲染而成的網頁操作 (V2.0 功能):**

        *   **開啟網頁瀏覽器，在網址列輸入以下網址並訪問:**

            ```
            http://localhost:5000/index.html
            ```

        *   **此方法無須啟動前端伺服器。**

    *   **方式三： 使用 `curl` 命令或其他 API 測試工具測試 API 端點 (適用於開發者或需要直接測試 API 功能的使用者):**

        *   打開另一個終端機視窗 (或使用同一個終端機視窗，但不要關閉正在執行 API 應用程式的視窗)，您可以使用 `curl` 命令或其他 API 測試工具 (例如 [Postman](https://www.postman.com/)) 來測試 API 端點。

        *   **使用 `curl` 命令測試 `/api/Students` 端點 (取得所有學生資料):**

            ```bash
            curl http://localhost:5000/api/Students
            ```

            如果 API 正常運作，您應該會在終端機中看到一個 JSON 陣列，其中包含了預設的學生資料 (種子資料)。 例如：

            ```json
            [
                {
                    "id": 1,
                    "name": "煜城 邵",
                    "class_name": "草莓",
                    "art_score": 89
                },
                {
                    "id": 2,
                    "name": "炎彬 姜",
                    "class_name": "草莓",
                    "art_score": 52
                },
                ...(省略部分資料)
                {
                    "id": 40,
                    "name": "越澤 董",
                    "class_name": "蘋果",
                    "art_score": 42
                }
            ]
            ```

        *   **其他 API 端點測試 (請參考 API 文件或 Controller 程式碼):**

            您可以根據 `Controllers/StudentsController.cs` 檔案中的程式碼，探索和測試其他 API 端點，例如：

            *   **取得特定學生資料 (Get Student by Id):**
                ```bash
                curl http://localhost:5000/api/Students/{id} *(請將 {id} 替換為實際的學生 Id，例如 1, 2, 3 等)*
                ```
            *   **新增學生資料 (Create Student):** (需要使用 `POST` 方法，並在請求 Body 中傳遞 JSON 格式的學生資料，具體格式請參考 `Models/Student.cs` 類別定義)
                ```bash
                curl -X POST -H "Content-Type: application/json" -d "{ \"name\": \"新的學生姓名\", \"class_name\": \"新的班級名稱\", \"art_score\": 95 }" http://localhost:5000/api/Students
                ```
            *   **更新學生資料 (Update Student):** (需要使用 `PUT` 方法，並在請求 Body 中傳遞 JSON 格式的學生資料，並在 URL 中指定要更新的學生 Id)
                ```bash
                curl -X PUT -H "Content-Type: application/json" -d "{ \"id\": 1, \"name\": \"更新後的學生姓名\", \"class_name\": \"更新後的班級名稱\", \"art_score\": 98 }" http://localhost:5000/api/Students/1
                ```
            *   **刪除學生資料 (Delete Student):** (需要使用 `DELETE` 方法，並在 URL 中指定要刪除的學生 Id)
                ```bash
                curl -X DELETE http://localhost:5000/api/Students/{id} *(請將 {id} 替換為實際的學生 Id，例如 1, 2, 3 等)*
                ```

**資料庫檔案**

專案預設使用 SQLite 資料庫，資料庫檔案為 `KindergartenArtScore.db`，位於專案根目錄下。 您可以使用 [DB Browser for SQLite](https://sqlitebrowser.org/) 或其他 SQLite 資料庫瀏覽器打開此檔案，查看和管理資料庫中的資料。

**作者**

[**Luffy860412**](https://github.com/Luffy860412)

***

**致謝**

感謝所有為 .NET 開發生態系統做出貢獻的開發者和社群。