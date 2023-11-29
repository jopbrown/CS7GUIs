# Code Summary

該軟體是一個包含日誌記錄功能的視窗應用程式，具備主要的功能模塊，包括計數器、溫度轉換、預訂航班、定時器和 CRUD 操作。主要的程式邏輯分佈在 MainForm.cs 中，並通過 LogForm.cs 處理日誌視窗的相關邏輯。程式進入點在 Program.cs 中，其中進行應用程式的初始化設定，然後啟動主視窗。日誌記錄使用 NLog 進行，並在需要時顯示相應的日誌視窗。

| File | Description |
| --- | --- |
| LogForm.cs | LogForm.cs 包含了表示日誌視窗的 C# 類別 LogForm。在窗口即将关闭时，通过处理 FormClosing 事件，检查关闭原因，如果是用户点击 X 按钮触发的事件，则取消默认窗口关闭行为，而是隐藏窗口。 |
| MainForm.cs | MainForm.cs 是主要的視窗應用程式檔案，包括了一個 MainForm 類別。這個類別實現了包含計數器、溫度轉換、預訂航班、定時器和 CRUD 功能的視窗應用程式。操作行為被記錄到 NLog 中，並在需要時顯示日誌視窗。 |
| Program.cs | Program.cs 包含了應用程式的進入點 Main 方法。在 Main 方法中，調用 ApplicationConfiguration.Initialize() 進行應用程式的初始化設定，然後使用 Application.Run(new MainForm()) 啟動主視窗。 |


## LogForm.cs

# LogForm.cs 檔案摘要

## 檔案描述
這個檔案是名為 "LogForm.cs" 的 C# 檔案，包含了一個類別 `LogForm`，該類別繼承自 `Form`，用於視窗應用程式的日誌視窗。

## 類別: LogForm
- `public partial class LogForm : Form`: 這是一個部分類別，繼承自 `Form`，表示日誌視窗的視窗表單。

### 建構子
- `public LogForm()`: 建構子用於初始化 `LogForm` 類別的新實例。在這個建構子中，調用了 `InitializeComponent` 方法。

### 方法: LogForm_FormClosing
- `private void LogForm_FormClosing(object sender, FormClosingEventArgs e)`: 這是一個處理視窗即將關閉的事件的方法。在這個方法中進行了以下操作：
  - 檢查關閉的原因是否是使用者點擊 X 按鈕觸發的關閉事件。
  - 如果是使用者點擊 X 按鈕觸發的事件，則取消預設的窗口關閉行為。
  - 隱藏窗口而不是關閉它，以避免視窗的實際關閉。

### 注意事項
- 這段程式碼的主要邏輯是在視窗即將關閉時檢查是否是由使用者觸發的，並在這種情況下取消默認的關閉行為，改為隱藏窗口。

## MainForm.cs

# MainForm.cs 檔案摘要

## 檔案描述
這個檔案是名為 "MainForm.cs" 的 C# 檔案，包含了一個類別 `MainForm`，該類別繼承自 `Form`，表示主要的視窗應用程式。

## 類別: MainForm

### 建構子
- `public MainForm()`: 建構子初始化 `MainForm` 類別的新實例，包括了初始化組件、創建 `LogForm` 實例以及顯示和隱藏它的操作。

### 事件: MainForm_Load
- `private void MainForm_Load(object sender, EventArgs e)`: 處理主視窗載入事件，設定書籍、定時器和 CRUD 功能。

### 方法: UIBtnShowLog_ButtonClick
- `private void UIBtnShowLog_ButtonClick(object sender, EventArgs e)`: 顯示日誌視窗的按鈕事件處理。

### 計數器部分
- 變數 `counter` 追蹤計數器數值。
- 方法 `UIBtnCount_Click` 處理計數器按鈕點擊事件，更新計數器數值並記錄到日誌。

### 溫度轉換部分
- 變數 `allowTriggerTextChange` 用於防止文字變更事件的循環調用。
- 方法 `UIInputC_TextChanged` 和 `UIInputF_TextChanged` 處理攝氏和華氏溫度輸入框的變更事件，同時記錄溫度轉換到日誌。

### 預訂航班部分
- 定義了列舉型別 `BookOption` 表示預訂選項，以及 `BookOptionDisplay` 類別用於在 UI 中顯示。
- 方法 `setupBook` 初始化預訂選項控制項。
- 方法 `UIOptionBook_SelectedIndexChanged`、`UIInputStartDate_TextChanged` 和 `UIInputReturnDate_TextChanged` 處理相應事件，並更新預訂選項 UI。
- 方法 `UIBtnBook_Click` 處理預訂按鈕點擊事件，記錄預訂信息並顯示提示框。

### 定時器部分
- 定義了計時器相關的變數和方法，包括設定計時器、計時器事件處理、滑動條變更事件等。

### CRUD 部分
- 定義了 `User` 類別表示用戶，並初始化用戶數據。
- 方法 `setupCRUD` 初始化 CRUD 控制項。
- 方法 `updateListBox` 更新用戶列表框。
- 方法 `UIInputFilter_TextChanged` 處理過濾文本框變更事件，並更新用戶列表。
- 方法 `UIListBox_SelectedIndexChanged` 處理用戶列表框選擇事件，更新用戶信息輸入框的內容。
- 方法 `UIBtnCreate_Click`、`UIBtnUpdate_Click` 和 `UIBtnDelete_Click` 處理創建、更新和刪除用戶的事件，同時記錄操作到日誌。

### 注意事項
- 這段程式碼實現了一個包含計數器、溫度轉換、預訂航班、定時器和 CRUD 功能的視窗應用程式。操作行為被記錄到 NLog 中，並在需要時顯示日誌視窗。

## Program.cs

# Program.cs 檔案摘要

## 檔案描述
這個檔案是名為 "Program.cs" 的 C# 檔案，包含了應用程式的進入點 `Main` 方法，並使用 `ApplicationConfiguration` 進行應用程式配置，最終啟動主視窗。

## 類別: Program

### 方法: Main
- `private static void Main()`: 主程式進入點。
  - 調用 `ApplicationConfiguration.Initialize()` 進行應用程式的初始化設定。
  - 使用 `Application.Run(new MainForm())` 啟動主視窗。

### 注意事項
- 這段程式碼是應用程式的進入點，初始化應用程式配置後啟動主視窗。
