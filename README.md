# Unity Data Storage Examples

This project shows two ways to store and display data in Unity: **Scriptable Objects** and **PlayerPrefs**.

---

## 1. Scriptable Objects


**Overview:**  
Scriptable Objects allow you to store data as an asset, independent of scene objects. Here we use `Playerdata` to store player info.

<img width="782" height="458" alt="image" src="https://github.com/user-attachments/assets/8e805fb1-c8fd-4c06-b2b4-35e243db80e8" />



<img width="796" height="188" alt="image" src="https://github.com/user-attachments/assets/2cd2c485-27b4-4489-8f29-447f3bb08831" />

**PlayerData**

<img width="361" height="244" alt="image" src="https://github.com/user-attachments/assets/44679bf1-8d34-46a1-9642-9cb3a3e3c225" />

**Game view**

<img width="759" height="362" alt="image" src="https://github.com/user-attachments/assets/a3f6b9bc-57a3-4281-a22d-4c3a3629b324" />

**Files:**
- `Playerdata.cs` – defines the ScriptableObject with `playerName`, `score`, and `health`.
- `PlayerControl.cs` – control script that reads data from the ScriptableObject and updates the UI.

**How It Works:**
1. Create a ScriptableObject instance in Unity via **Assets → Create → ScriptableObjects → Sample Safe House**.
2. Fill in values for `playerName`, `score`, and `health` in the Inspector.
3. Attach `PlayerControl` to a GameObject and assign the ScriptableObject and UI Text elements.
4. Press **Play** – the UI shows the values from the ScriptableObject.

---

## 2. PlayerPrefs

**Overview:**  
PlayerPrefs allows storing and retrieving data between sessions. The script demonstrates real-time updates and saving three data points.

**Files:**
- `PlayerPrefsManager.cs` – stores `playerName`, `score`, and `health` using PlayerPrefs. Deletes old cached data at start for fresh testing.

**How It Works:**
1. Create UI Text elements for Health, Score, and Player Name.
2. Attach `PlayerPrefsManager` to a GameObject and assign the UI elements.
3. Press **Play**:
   - Health decreases over time.
   - Score increases over time.
   - Player Name displays correctly.
4. Data is saved automatically in PlayerPrefs.
5. Restart the game to see the reset effect due to `PlayerPrefs.DeleteAll()`.


##
**PlayerPrefs


<img width="616" height="749" alt="image" src="https://github.com/user-attachments/assets/550345bc-cc03-439a-8688-0cc55bc8ad1b" />


**Display View**


<img width="636" height="189" alt="image" src="https://github.com/user-attachments/assets/9877e40c-a46b-496a-bef7-bd4751bce369" />


