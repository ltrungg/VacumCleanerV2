# Robot Garbage Collector

> **Game 2D Unity** đơn giản: điều khiển robot dọn rác, quay sprite theo hướng di chuyển, đạt đủ điểm sẽ thắng cuộc.

## 🎮 Tính năng chính

- **Điều khiển linh hoạt**: Dùng phím **W/A/S/D** hoặc **mũi tên** để di chuyển 4 hướng.
- **Quay sprite động**: Robot tự động xoay 0°, 90°, 180°, -90° dựa trên hướng di chuyển (dựa trên sprite gốc nhìn lên).
- **Thu gom rác**: Khi va chạm với đối tượng có tag `Garbage`, rác sẽ bị huỷ và điểm số tăng.
- **Điểm số & UI**: Dùng **TextMeshPro** hiển thị điểm. Khi đạt _WinScore_ (mặc định 5), game dừng và hiện giao diện “You Win”.
- **Khởi động lại**: Cho phép restart ngay trong màn hình chiến thắng.

## ⚙️ Yêu cầu

- Unity **6.x** (hoặc tương đương hỗ trợ `Rigidbody2D.linearVelocity`)
- .NET **8.0**
- Package **TextMeshPro** (miễn phí kèm Unity)

## 🚀 Cài đặt & Chạy project

1. **Clone** về máy:
   ```bash
   https://github.com/ltrungg/VacumCleanerV2
