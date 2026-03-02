# Unity Data Storage Examples

This project shows two ways to store and display data in Unity: **Scriptable Objects** and **PlayerPrefs**.

---

## 1. Scriptable Objects


<img width="796" height="188" alt="image" src="https://github.com/user-attachments/assets/2cd2c485-27b4-4489-8f29-447f3bb08831" />

**PlayerData**

<img width="361" height="244" alt="image" src="https://github.com/user-attachments/assets/44679bf1-8d34-46a1-9642-9cb3a3e3c225" />

**Game view**

<img width="759" height="362" alt="image" src="https://github.com/user-attachments/assets/a3f6b9bc-57a3-4281-a22d-4c3a3629b324" />

### What It Does
- Stores data in an asset (independent of scene).
- Can have variables like int, float, string.
- Control script reads the data and shows it in UI or scene.

### How to Test
1. Create a ScriptableObject asset in **Assets → Create → Your ScriptableObject**.
2. Fill in values in the Inspector.
3. Attach the control script to a GameObject and link the ScriptableObject.
4. Press Play – UI should show the stored values.

---

## 2. PlayerPrefs

### What It Does
- Stores data that persists between sessions.
- Can save int, float, string.
- Updates values over time (e.g., health decreases, score increases).
- Optionally clears old saved data with `PlayerPrefs.DeleteAll()`.

### How to Test
1. Create UI Text elements for Health, Score, and Player Name.
2. Attach PlayerPrefsManager to a GameObject and assign UI elements.
3. Press Play – see values update in real-time.
4. Stop and restart to test reset if using `DeleteAll()`.

---

## Notes
- ScriptableObjects: good for static/config data.
- PlayerPrefs: good for saving player progress or settings.


##
**PlayerPrefs
**Controller**
<img width="616" height="749" alt="image" src="https://github.com/user-attachments/assets/550345bc-cc03-439a-8688-0cc55bc8ad1b" />


**Display View**
<img width="636" height="189" alt="image" src="https://github.com/user-attachments/assets/9877e40c-a46b-496a-bef7-bd4751bce369" />


