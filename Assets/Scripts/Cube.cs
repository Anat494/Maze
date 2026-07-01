using UnityEngine;

public class Cube : MonoBehaviour
{
    // C# 8.0/Unity 2020: Dùng biến public thông thường thay cho [field: SerializeField] với Property
    public float Speeds = 5f;
    public string StrBienToanCuc = "Demo C# Script File";

    [SerializeField] private GameObject targetObject;
    private int _soNguyen = 10;
    
    // Đã sửa: Unity 2020 bắt buộc phải ghi rõ 'new Vector3(...)' chứ không được ghi mỗi 'new(...)'
    private Vector3 _vector3 = new Vector3(3f, 0f, 0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(StrBienToanCuc);
        string strBienCucBo = "bien cuc bo";
        Debug.Log(strBienCucBo);
        ThucHanhTruyenBien();
        KetNoiDoiTuong();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * (Speeds * Time.deltaTime), Space.World);
    }

    private void ThucHanhTruyenBien()
    {
        int intValue = 10;
        int intReference = 10;
        Debug.Log($"PassByValue trả về:{PassByValue(intValue)}");
        Debug.Log($"Biến gốc intValue sau hàm: {intValue}");
        PassByReference(ref intReference);
        Debug.Log($"Biến gốc intReference sau hàm (ref):{intReference}");
    }

    // Expression-bodied member (C# 6.0+) hoạt động tốt trên Unity 2020
    public int PassByValue(int num) => num + 100;
    
    public void PassByReference(ref int intNum)
    {
        intNum += 2;
    }

    private void KetNoiDoiTuong()
    {
        // Sửa logic câu lệnh điều kiện để hoạt động đúng ý đồ
        if (targetObject != null)
        {
            Debug.Log($"[Cách 2] Đã kết nối trực tiếp đến: {targetObject.name}");
        } 
        else 
        {
            targetObject = GameObject.Find("Sphere");
            if (targetObject != null)
            {
                Debug.Log($"[Cách 1] đã tìm thấy đối tượng: {targetObject.name}");
            }
            else
            {
                Debug.LogWarning("Không tìm thấy đối tượng nào tên là 'Sphere' trong Scene!");
            }
        }
    }
}