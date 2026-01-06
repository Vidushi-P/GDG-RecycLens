# RecycLens: AR-Powered Recycling Education Solution ♻️

**RecycLens** is an Augmented Reality (AR) application built with Unity that transforms how people learn about waste management. By blending the digital and physical worlds, the app provides interactive, 3D step-by-step guides for recycling various materials, making sustainability intuitive and engaging. This project was created for the **Google Developer Groups' TechSprint** of R.M.K. Engineering College **(HackNexa 2026)**.

---

## 🌟 Key Features

* **Interactive 3D Tutorials:** Visualize the recycling process for Plastic, Glass, Cardboard, and Metals through high-quality 3D models animated in your physical space.
* **AI-Powered Avatar:** An interactive 3D guide that assists users, answers questions, and provides real-time feedback on recycling steps.
* **Nearby Center Locator:** Integrated Google Maps functionality to find and navigate to the nearest recycling facilities based on the user's current GPS location.
* **Real-time Progress Tracking:** Powered by Firebase to save user milestones and recycling impact.

---

## 🏗 System Architecture



The project follows a modular architecture:
1.  **Client Layer:** Unity-based mobile application handling SLAM (Simultaneous Localization and Mapping) via ARCore.
2.  **Logic Layer:** Manages 3D state machines, avatar animations, and API requests.
3.  **Data Layer:** Firebase manages user data and asset delivery, while Google Maps API provides geospatial data.

---

## 🛠 Tech Stack

* **Engine:** Unity (2022.3 LTS)
* **AR Framework:** Google ARCore / AR Foundation
* **Backend:** Firebase (Auth, Firestore, Storage)
* **APIs:** Google Maps Platform (Places API, Maps SDK for Unity)
* **Version Control:** Git LFS (for large .fbx assets)

---

## 🚀 Getting Started

### Prerequisites
* Unity Hub & Unity Editor (2022.3+)
* Android device with ARCore support
* Google Cloud Platform account (for Maps API keys)
* Firebase project credentials

### Installation
1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/Vidushi-P/GDG-RecycLens.git](https://github.com/Vidushi-P/GDG-RecycLens.git)
    ```
2.  **LFS Initialization:**
    Since this project contains large 3D models, ensure Git LFS is installed:
    ```bash
    git lfs pull
    ```
3.  **Setup API Keys:**
    * Add your `google-services.json` to the `Assets/` folder.
    * Add your Google Maps API key in the Unity Inspector under `Google Maps Service Provider`.
