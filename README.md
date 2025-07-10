# 🌿 Greenhouse – Monitoring and Management System

A desktop application for monitoring and managing a greenhouse environment, developed in C# using Windows Forms. The project enables real-time visualization of sensor data, user management, alarm tracking, and device monitoring.

## 📌 Key Features

- 📊 **Data Visualization** – interactive charts displaying environmental parameters (e.g., temperature, humidity, light).
- 🔐 **Login and Authorization System** – user roles such as admin and operator.
- 📦 **Database Integration** – stores devices, parameters, alarms, and historical data.
- 🚨 **Alarm System** – allows alarm thresholds configuration and displays warning messages.
- ⚙️ **Device Management** – list of devices with editable properties and assigned parameters.
- 👥 **User Management** – user account creation, editing, and password management.
- 📁 **History & Reports** – logs of sensor data and triggered alarms.

## 🗂️ Project Structure

- `Form1.cs` – main application form and notification handling.
- `ChartPage.cs`, `MainPage.cs` – pages responsible for chart rendering and data visualization.
- `LoginForm.cs`, `UserManager.cs`, `User.cs` – login system and user management.
- `Alarm.cs`, `AlarmParameter.cs`, `Record.cs` – alarm system logic and logging.
- `Device.cs` – management of devices and their parameters.
- `All_data.cs` – internal data structures.
- `GreenHouse.sln` – Visual Studio solution file.

## 🛠 Hardware
The device is built on:
- ESP-WROOM-32 (microcontroller)
- DHT11 (temperature and humidity sensor)

## 💻 Software

- **Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **Database**: Wampp Server
- **IDE**: Visual Studio

## 🖼️ Preview

### 🔐 Login Form
![LoginForm](https://github.com/user-attachments/assets/c343a7f5-c80c-43f8-9193-1d4b3993a913)

### 🏠 Main Dashboard
![MainPage](https://github.com/user-attachments/assets/d38959b1-48db-41a7-b489-0b4192118ec1)

### 📊 Chart View
![ChartForm](https://github.com/user-attachments/assets/356dbc51-9226-4583-bfaa-267ea49c8cc3)

### 👤 Admin Panel
![AdminForm](https://github.com/user-attachments/assets/5bfceb2b-8435-4d42-8704-a4e70e6e7c77)

## 🚀 Getting Started

1. Clone the repository
2. Configure the wampp server and your database in phpMyAdmin with tables and procedures form Database folder.
3. Open the GreenHouse.sln file in Visual Studio to build and run the application

## 📜 License
This repository is for educational and personal portfolio use. Feel free to browse and learn!


