# SecureCrypt 🔐

A lightweight Windows desktop application built with **C# (WinForms)** that allows users to securely encrypt, decrypt, and store sensitive data using a secret-key-based encryption system.

Includes **user authentication**, **password strength validation**, and a **real-time database-powered encrypted data bank**.

---

## 🚀 Features

### 🔐 User Authentication
* **Sign Up Form** with input validation.
* **Sign In Form** with credential verification.
* Passwords stored securely in the database (**salted and hashed**).

### 🔏 Encryption / Decryption
* Encrypt any text using a user-provided **secret key**.
* Decrypt data using the correct matching secret key.
* **AES-based algorithm** (or your chosen strong symmetric algorithm).

### 🗄️ Encrypted Data Bank
* Fetches encrypted data from the database in **real-time**.
* Displays **nickname + encrypted text** in a table.
* Each row includes:
    * Secret key input field
    * Decrypt button
    * Output changes **in-place** on successful decryption.

### 🧪 Password Strength Checker
* **Real-time** password complexity scoring.
* Checks:
    * Length
    * Numbers
    * Uppercase + lowercase mix
    * Special characters
* Strength categories: **Weak → Moderate → Strong → Very Strong**.

### 💾 Database Integration
* **SQL Server** database.
* Includes **stored procedures** for: User registration, Login verification, Storing encrypted data, and Fetching user data.

---

## 🛠️ Technologies Used

| Category | Technology / Component | Details |
| :--- | :--- | :--- |
| **Frontend / Application** | C# (.NET Framework / WinForms) | Desktop GUI, Custom UI components, Error handling & validation |
| **Backend / Database** | SQL Server, ADO.NET | Data storage, connectivity, and data access layer |
| **Security** | AES Encryption | Symmetric encryption for data |
| **Security** | MD5 Hashing (with Salt) | Secure storage of user passwords |
| **Project Structure** | User-specific data isolation | Ensures each user can only access their own encrypted entries. |

---


## ⚙️ How to Run the Project

### Prerequisites
* **Windows OS**
* **.NET Framework** Installed
* **SQL Server** / SQL Express (required for database)
* **Visual Studio** (recommended for building/debugging)

### Steps
1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/yourusername/securecrypt.git](https://github.com/yourusername/securecrypt.git)
    ```
2.  Open the solution (`SecureCrypt.sln`) in Visual Studio.
3.  **Restore or attach the database** (`SecureCryptDB.mdf`) to your local SQL Server instance.
4.  **Update your `connectionString`** in the `App.config` file to match your SQL Server setup.
5.  Build & run the project (F5).
6.  *Optional:* Execute the stored procedures in `StoredProcedures.sql` if they are not already attached with the `.mdf` file.

---

## 🗄️ Database Stored Procedures

The following stored procedures are used for secure and validated database operations:

1.  ### `sp_RegisterUser`
    * **Description:** Registers a new user.
    * **Inputs:** `@username`, `@email`, `@passwordHash`
    * **Outputs:** `status` (e.g., success, email duplicate)
    * **Logic:** Checks for email duplication, then inserts the new user record.

2.  ### `sp_LoginUser`
    * **Description:** Validates user login credentials.
    * **Inputs:** `@email`, `@passwordHash` (hashed input for comparison)
    * **Output:** `@userId` if credentials are valid.

3.  ### `sp_SaveEncryptedData`
    * **Description:** Stores encrypted text with a nickname under the user's ID.
    * **Inputs:** `@userId`, `@nickname`, `@encryptedData`

4.  ### `sp_FetchUserData`
    * **Description:** Fetches all encrypted data entries belonging to a specific user.
    * **Inputs:** `@userId`
    * **Outputs:** Table result including `nickname` and `encryptedString`.

---

## 🧭 Application Flow

1.  **User signs up** via the `SignUp` form.
2.  **User logs in** via the `SignIn` form.
3.  **Home page** is displayed, showing the username.
4.  User can navigate to:
    * **Encryption page** to encrypt new data and save it to the bank.
    * **Database page** to view previously saved encrypted entries.
5.  **To Decrypt Data:**
    * The user **enters the original secret key** in the corresponding row.
    * Clicks the **Decrypt button**.
    * The table row updates automatically with the decrypted text upon success.

---

## 🖼️ Screenshots

### 🔐 Login & Signup
![Sign Up](img/1%20(1).png)
![Sign In](img/1%20(2).png)

### 🔏 Encryption & Decryption
![Encryption Page](img/1%20(3).png)
![Decryption Page](img/1%20(4).png)

### 🗄️ Encrypted Data Bank
![Database View](img/1%20(5).png)

### 🧪 Password Strength Checker
![Password Strength Checker](img/1%20(6).png)

---

## 🛡️ Security Notes

* Always keep your **secret keys private**; they are the sole means of decryption.
* **Never store raw passwords**. All credentials must be **hashed and salted** before storage.
* Use a strong, modern hashing algorithm (e.g., Argon2, Scrypt, or strong iteration of PBKDF2) instead of MD5 for production environments. MD5 is listed here based on the project description but is generally considered outdated for password hashing.
* Implement **user-specific data isolation** to ensure a user cannot query another user's data.
* Do **not expose database files or connection strings** publicly.

---

## 🪟 Packaging as a Windows App

To build your final deliverable:

1.  Use the **Publish → Folder** option in Visual Studio.
2.  Generate the executable and supporting files inside the output folder.
3.  Include the following in your distribution zip file:
    * The generated `/publish` folder (containing the `.exe` and necessary DLLs).
    * The database file (`SecureCryptDB.mdf`).
    * The `ReadMe.md` file.

---


## 💬 Author

**Showrab Bin Habib**

📧 **Contact:** `showrabbinhabib@gmail.com`
