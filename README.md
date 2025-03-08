# KindergartenArtScoreAPI (幼兒園美術成績管理系統 API) - V2.0 UI介面版本

**簡介**

`KindergartenArtScoreAPI` 是一個使用 ASP.NET Core Web API 框架開發的後端 API 專案，**V2.0 版本更整合了網頁使用者介面 (UI)**，旨在為幼兒園美術評分系統提供更完善、更易用的解決方案。 這個專案不僅提供後端 API 端點，用於管理學生的美術評分資料，**V2.0 版本更加入了直觀的網頁使用者介面，讓使用者可以直接在瀏覽器中操作系統功能。**

**主要功能 (V2.0 版本更新)**

* **✅  完整 CRUD API 後端:**  提供學生美術評分資料的 **新增 (Create)、讀取 (Read)、更新 (Update)、刪除 (Delete)** API 端點，方便程式開發者進行系統整合和資料管理。
* **✨  全新網頁使用者介面 (UI):**  V2.0 版本 **全新開發網頁前端 UI**，使用者可以透過瀏覽器 **直觀地操作** 幼兒園美術評分系統，無需額外編寫程式碼或使用 API 測試工具。
    *   **🎨  學生資料列表:** 以表格形式 **清晰呈現** 所有學生的基本資料 (姓名、班級) 和美術評分，方便瀏覽和查詢。
    *   **➕  新增學生功能:** 提供 **友善的表單介面**，讓使用者可以輕鬆 **新增** 學生資料到系統中。
    *   **✏️  編輯學生功能:** 目前提供 **基本編輯功能**，允許使用者修改現有的學生資料。
    *   **❌  刪除學生功能:** 目前提供 **基本刪除功能**，允許使用者刪除不必要的學生資料。
* **資料儲存:** 使用輕量級的 SQLite 資料庫作為資料儲存方案，方便部署和使用。
* **種子資料:** 內建種子資料 (Seed Data) 功能，在資料庫初始化時自動填充示範資料，方便快速測試和功能展示。
* **RESTful API 設計:** 遵循 RESTful API 設計原則，提供清晰、易於使用的 API 端點，**除了網頁 UI 操作外，開發者仍然可以透過 API 端點直接存取和管理資料。**
* **使用 .NET 7 開發:** 基於最新的 .NET 7 平台構建，擁有良好的效能和跨平台能力。
* **🐍 API 輸出資料 KEY 名稱自動轉換為 snake_case:** API  輸出的 JSON  資料中，KEY 名稱已自動從 PascalCase  風格轉換為 `snake_case` 風格 (例如 `className` 轉換為 `class_name`，`artScore` 轉換為 `art_score`)，更符合 JavaScript  和 Web  開發慣例，方便前端開發者使用。

**技術棧**

* **後端 API:**  [.NET 7](https://dotnet.microsoft.com/zh-tw/download/dotnet/7.0), [ASP.NET Core Web API](https://learn.microsoft.com/zh-tw/aspnet/core/web-api/?view=aspnetcore-7.0)
* **前端 UI:**  HTML, CSS, JavaScript, Fetch API
* **ORM:**  [Entity Framework Core (EF Core)](https://learn.microsoft.com/zh-tw/ef/core/)
* **資料庫:**  [SQLite](https://www.sqlite.org/index.html)
* **假資料產生:**  [Bogus](https://github.com/bchavez/Bogus)
* **開發工具:**  [Visual Studio Code](https://code.visualstudio.com/) 或其他 .NET 開發工具

**環境需求 (Prerequisites)**

在執行此專案之前，請確保您的開發環境已安裝以下組件：

* **[.NET SDK 7.0](https://dotnet.microsoft.com/zh-tw/download/dotnet/7.0):**  請前往 [官方 .NET 下載頁面](https://dotnet.microsoft.com/zh-tw/download/dotnet/7.0) 下載並安裝 .NET SDK 7.0 或更高版本。  安裝完成後，請在終端機或命令提示字元中執行 `dotnet --version` 命令，確認 .NET SDK 已成功安裝並可正常使用。

* **[Visual Studio Code (建議)](https://code.visualstudio.com/):**  雖然您可以使用任何文字編輯器或 IDE 開發 .NET 專案，但我們 *強烈建議您使用 [Visual Studio Code](https://code.visualstudio.com/) 搭配 [C# 擴充套件](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) 進行開發。  Visual Studio Code 是一款輕量級、跨平台的程式碼編輯器，並擁有豐富的擴充功能，可以極大地提升 .NET 開發效率。

* **[SQLite 資料庫瀏覽器 (DB Browser for SQLite) (建議)](https://sqlitebrowser.org/):**  雖然 SQLite 資料庫檔案可以由程式碼自動建立，但為了方便您 *直接查看和驗證資料庫內容，我們 *強烈建議您安裝 [DB Browser for SQLite](https://sqlitebrowser.org/) 或其他 SQLite 資料庫瀏覽器。  DB Browser for SQLite 是一款免費、開源、跨平台的 SQLite 資料庫管理工具，可以讓您輕鬆地 *打開、檢視、編輯 SQLite 資料庫檔案。

**如何執行專案 (Getting Started)**

以下是在本機環境中執行 `KindergartenArtScoreAPI` 專案的詳細步驟：

1.  **從 GitHub 克隆專案程式碼:**

    打開終端機或命令提示字元，切換到您希望存放專案程式碼的目錄，然後執行以下 `git clone` 命令：

    ```bash
    git clone [https://github.com/](https://github.com/)Luffy860412/KindergartenArtScoreAPI.git
    ```

2.  **切換到專案目錄:**

    克隆完成後，使用 `cd` 命令切換到專案目錄：

    ```bash
    cd KindergartenArtScoreAPI
    ```

3.  **還原 NuGet 套件 (通常非必要，但建議執行):**

    雖然 `dotnet run` 命令通常會自動還原 NuGet 套件，但為了確保專案依賴套件完整，建議您先手動執行 `dotnet restore` 命令，還原專案所需的 NuGet 套件：

    ```bash
    dotnet restore
    ```

4.  **更新資料庫 (建立資料庫和填充種子資料):**

    執行以下 `dotnet ef database update` 命令，Entity Framework Core 會自動執行 Migration 來 *建立資料庫結構，並 *執行種子資料程式碼，填充初始資料：

    ```bash
    dotnet ef database update
    ```

    在執行此命令時，請 *仔細觀察終端機輸出訊息， *確保命令 *成功執行，並且 *沒有任何錯誤訊息。 您應該會看到類似 `Applying migration 'InitialCreate'` 和 `Done.` 的訊息，以及 `INSERT INTO "Students"` 等 *種子資料插入語句。*

5.  **執行 API 應用程式:**

    執行以下 `dotnet run` 命令，啟動 API 應用程式：

    ```bash
    dotnet run
    ```

    如果應用程式成功啟動，您應該會在終端機中看到類似 `Now listening on: http://localhost:5000` 的訊息，表示 API 正在 `http://localhost:5000` 這個網址監聽請求。

6.  **選擇操作方式:**

    API 應用程式啟動後，您有兩種方式可以與 KindergartenArtScoreAPI 互動：

    *   **方式一： 使用網頁瀏覽器操作 (全新 V2.0 功能 - 推薦使用者使用):**

        *   **開啟網頁瀏覽器，在網址列輸入以下網址並訪問:**

            ```
            http://localhost:5000/index.html
            ```

        *   **您將看到 KindergartenArtScoreAPI 的網頁使用者介面。**  您可以在網頁介面上瀏覽學生列表、新增學生資料、編輯和刪除學生資料 (V2.0 版本初步實作)。  **透過網頁介面操作，您可以更直觀、更便捷地使用 KindergartenArtScoreAPI 系統的功能。**

    *   **方式二： 使用 `curl` 命令或其他 API 測試工具測試 API 端點 (適用於開發者或需要直接測試 API 功能的使用者):**

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

---

**修改重點摘要:**

* **標題更新:**  加入 "V2.0 網頁使用者介面版本"，更明確標示版本特性。
* **簡介更新:**  強調 V2.0 版本整合了網頁使用者介面。
* **主要功能更新:**
    *   加入 "✨ 全新網頁使用者介面 (UI)"  功能描述，詳細列出 UI 的主要功能。
    *   將 "學生美術評分管理"  更名為 "✅ 完整 CRUD API 後端"，並強調 API 後端仍然存在且功能完整。
    *   在 "RESTful API 設計"  中強調 API 端點仍然可用，使用者可選擇網頁 UI 或直接 API 操作。
    *   在 "技術棧" 中加入前端 UI 相關技術 (HTML, CSS, JavaScript, Fetch API)。
    *   在 "主要功能" 和 "技術棧" 中加入 **API 輸出資料 KEY 名稱自動轉換為 snake_case** 的描述，突出此項改進。
* **如何執行專案 (Getting Started) 更新:**
    *   在步驟 6 "測試 API 端點"  中， **明確區分兩種操作方式:**  方式一 (網頁 UI 操作 - 推薦使用者) 和 方式二 (API 測試工具 - 適用於開發者)。
    *   **詳細描述如何使用網頁瀏覽器訪問和操作網頁 UI 介面。**
    *   保留原有的 `curl` 命令 API 測試說明，方便開發者直接測試 API 端點。