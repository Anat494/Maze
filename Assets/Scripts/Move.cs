using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    private CharacterController _controller;

    void Start()
    {
        // Lấy component Character Controller gắn trên Player
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 1. Lấy đầu vào (Input) từ bàn phím (W, A, S, D hoặc các phím mũi tên)
        float moveX = Input.GetAxis("Horizontal"); // Trục ngang (A/D hoặc Mũi tên Trái/Phải)
        float moveZ = Input.GetAxis("Vertical");   // Trục dọc (W/S hoặc Mũi tên Lên/Xuống)

        // 2. Tạo vector hướng di chuyển dựa trên hướng nhìn của Player
        Vector3 moveDirection = transform.right * moveX + transform.forward * moveZ;

        // 3. Thực hiện di chuyển thông qua Character Controller
        // Hàm .Move này sẽ tự động xử lý va chạm, chặn Player lại nếu đâm vào tường
        _controller.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}