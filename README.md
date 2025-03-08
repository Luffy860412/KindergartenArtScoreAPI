# KindergartenArtScoreAPI (幼兒園美術評分系統 API)

**簡介**

`KindergartenArtScoreAPI` 是一個使用 ASP.NET Core Web API 框架開發的後端 API 專案，旨在為幼兒園美術評分系統提供數據存取和管理功能。 這個 API 提供了一系列端點，用於管理學生的美術評分資料，包括新增、讀取、更新和刪除學生資料。

**主要功能**

* **學生美術評分管理:** 提供 API 端點以進行學生的基本資料 (姓名、班級) 和美術評分 (ArtScore) 的 CRUD (新增、讀取、更新、刪除) 操作。
* **資料儲存:** 使用輕量級的 SQLite 資料庫作為資料儲存方案，方便部署和使用。
* **種子資料:** 內建種子資料 (Seed Data) 功能，在資料庫初始化時自動填充示範資料，方便快速測試和功能展示。
* **RESTful API 設計:** 遵循 RESTful API 設計原則，提供清晰、易於使用的 API 端點。
* **使用 .NET 7 開發:** 基於最新的 .NET 7 平台構建，擁有良好的效能和跨平台能力。

**技術棧**

* [.NET 7](https://dotnet.microsoft.com/zh-tw/download/dotnet/7.0)
* [ASP.NET Core Web API](https://learn.microsoft.com/zh-tw/aspnet/core/web-api/?view=aspnetcore-7.0)
* [Entity Framework Core (EF Core)](https://learn.microsoft.com/zh-tw/ef/core/)
* [SQLite](https://www.sqlite.org/index.html)
* [Bogus](https://github.com/bchavez/Bogus) (用於生成假資料)
* [Visual Studio Code](https://code.visualstudio.com/) 或其他 .NET 開發工具

**環境需求 (Prerequisites)**

在執行此專案之前，請確保您的開發環境已安裝以下組件：

* **[.NET SDK 7.0](https://dotnet.microsoft.com/zh-tw/download/dotnet/7.0):**  請前往 [官方 .NET 下載頁面](https://dotnet.microsoft.com/zh-tw/download/dotnet/7.0)  下載並安裝 .NET SDK 7.0 或更高版本。  安裝完成後，請在終端機或命令提示字元中執行 `dotnet --version`  命令，確認 .NET SDK  已成功安裝並可正常使用。

* **[Visual Studio Code (建議)](https://code.visualstudio.com/):**  雖然您可以使用任何文字編輯器或 IDE 開發 .NET 專案，但我們 *強烈建議您使用 [Visual Studio Code](https://code.visualstudio.com/)  搭配 [C# 擴充套件](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)  進行開發。  Visual Studio Code  是一款輕量級、跨平台的程式碼編輯器，並擁有豐富的擴充功能，可以極大地提升 .NET 開發效率。

* **[SQLite 資料庫瀏覽器 (DB Browser for SQLite) (建議)](https://sqlitebrowser.org/):**  雖然 SQLite 資料庫檔案可以由程式碼自動建立，但為了方便您 *直接查看和驗證資料庫內容，我們 *強烈建議您安裝 [DB Browser for SQLite](https://sqlitebrowser.org/)  或其他 SQLite 資料庫瀏覽器。  DB Browser for SQLite  是一款免費、開源、跨平台的 SQLite 資料庫管理工具，可以讓您輕鬆地 *打開、檢視、編輯 SQLite 資料庫檔案。

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

    執行以下 `dotnet ef database update` 命令，Entity Framework Core  會自動執行 Migration  來 *建立資料庫結構，並 *執行種子資料程式碼，填充初始資料：

    ```bash
    dotnet ef database update
    ```

    在執行此命令時，請 *仔細觀察終端機輸出訊息， *確保命令 *成功執行，並且 *沒有任何錯誤訊息。  您應該會看到類似 `Applying migration 'InitialCreate'` 和 `Done.`  的訊息，以及 `INSERT INTO "Students"`  等 *種子資料插入語句。*

5.  **執行 API 應用程式:**

    執行以下 `dotnet run` 命令，啟動 API 應用程式：

    ```bash
    dotnet run
    ```

    如果應用程式成功啟動，您應該會在終端機中看到類似 `Now listening on: http://localhost:5000`  的訊息，表示 API  正在 `http://localhost:5000`  這個網址監聽請求。

6.  **測試 API 端點:**

    API 應用程式啟動後，您可以使用 `curl` 命令或其他 API  測試工具 (例如 [Postman](https://www.postman.com/))  來測試 API 端點。

    **使用 `curl` 命令測試 `/api/Students`  端點 (取得所有學生資料):**

    打開另一個終端機視窗 (或使用同一個終端機視窗，但不要關閉正在執行 API 應用程式的視窗)，執行以下 `curl` 命令：

    ```bash
    curl http://localhost:5000/api/Students
    ```

    如果 API  正常運作，您應該會在終端機中看到一個 JSON  陣列，其中包含了預設的學生資料 (種子資料)。  例如：

    ```json
    [
        {
            "id": 1,
            "name": "煜城 邵",
            "className": "草莓",
            "artScore": 89
        },
        {
            "id": 2,
            "name": "炎彬 姜",
            "className": "草莓",
            "artScore": 52
        },
        ...(省略部分資料)
        {
            "id": 40,
            "name": "越澤 董",
            "className": "蘋果",
            "artScore": 42
        }
    ]
    ```

    **其他 API 端點測試 (請參考 API 文件或 Controller 程式碼):**

    您可以根據 `Controllers/StudentsController.cs`  檔案中的程式碼，探索和測試其他 API 端點，例如：

    * **取得特定學生資料 (Get Student by Id):**
      ```bash
      curl http://localhost:5000/api/Students/{id}   *(請將 {id} 替換為實際的學生 Id，例如 1, 2, 3 等)*
      ```
    * **新增學生資料 (Create Student):**  (需要使用 `POST` 方法，並在請求 Body 中傳遞 JSON  格式的學生資料，具體格式請參考 `Models/Student.cs`  類別定義)
      ```bash
      curl -X POST -H "Content-Type: application/json" -d "{ \"name\": \"新的學生姓名\", \"className\": \"新的班級名稱\", \"artScore\": 95 }" http://localhost:5000/api/Students
      ```
    * **更新學生資料 (Update Student):**  (需要使用 `PUT` 方法，並在請求 Body 中傳遞 JSON  格式的學生資料，並在 URL 中指定要更新的學生 Id)
      ```bash
      curl -X PUT -H "Content-Type: application/json" -d "{ \"id\": 1, \"name\": \"更新後的學生姓名\", \"className\": \"更新後的班級名稱\", \"artScore\": 98 }" http://localhost:5000/api/Students/1
      ```
    * **刪除學生資料 (Delete Student):**  (需要使用 `DELETE` 方法，並在 URL 中指定要刪除的學生 Id)
      ```bash
      curl -X DELETE http://localhost:5000/api/Students/{id}  *(請將 {id} 替換為實際的學生 Id，例如 1, 2, 3 等)*
      ```

**資料庫檔案**

專案預設使用 SQLite  資料庫，資料庫檔案為 `KindergartenArtScore.db`，位於專案根目錄下。  您可以使用 [DB Browser for SQLite](https://sqlitebrowser.org/)  或其他 SQLite 資料庫瀏覽器打開此檔案，查看和管理資料庫中的資料。


**作者**

[**Luffy860412**](https://github.com/Luffy860412)

***

**貢獻**

歡迎任何形式的貢獻！  如果您發現 Bug  或有任何功能建議，請提交 Issue  或 Pull Request。

**致謝**

感謝所有為 .NET 開發生態系統做出貢獻的開發者和社群。