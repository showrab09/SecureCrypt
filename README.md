# SecureCrypt
SecureCrypt – Lightweight Encryption & Decryption Tool 🔐

SecureCrypt is a simple, fast, and user-friendly encryption tool built to help users secure sensitive messages and files using strong cryptographic techniques.
This project demonstrates core cybersecurity concepts such as encryption, decryption, hashing, key management, and secure data handling.

🚀 Features

Encrypt text or files using secure algorithms

Decrypt anytime with the correct key

Supports AES-256 encryption

Built with a clean and intuitive interface

Lightweight, fast, and beginner-friendly

Demonstrates real-world cybersecurity principles

Great for learning cryptography + Python security libraries

🔧 Tech Stack

Language: Python

Libraries: cryptography (Fernet / AES)

Platform: Cross-platform

🛠️ How It Works

User enters text or selects a file

SecureCrypt generates a unique secret key

The key encrypts the data using AES-256

The encrypted output becomes unreadable gibberish

User can later decrypt using the same key

📁 Project Structure
SecureCrypt/
│── securecrypt.py
│── README.md
│── requirements.txt
│── output/
│   ├── encrypted.txt
│   └── decrypted.txt
└── keys/
    └── secret.key

▶️ How to Run
1. Install dependencies
pip install cryptography

2. Run the app
python securecrypt.py

3. Encrypt text

Enter your message

The program generates:

encrypted.txt

secret.key

4. Decrypt text

Provide the correct key

Output saved in decrypted.txt

🧪 Example

Input:

Hello, this is SecureCrypt!


Encrypted:

gAAAAABlXYZ82Adw...


Decrypted:

Hello, this is SecureCrypt!

🔐 Security Notes

Keep your secret key safe — without it, decryption is impossible

AES-256 ensures industry-level security

Generated keys are unique and not stored online

🧩 Use Cases

Secure personal notes

Encrypt files before storing them

Learn how encryption works

Demonstrate cybersecurity concepts in school or SOC training

📌 Future Improvements

GUI interface

File drag-and-drop encryption

Multi-algorithm support

Cloud key vault integration

🤝 Contributions

Contributions, issues, and feature requests are welcome!
Feel free to open a pull request.

📧 Contact

Developed by Showrab Bin Habib
For questions: your email here
