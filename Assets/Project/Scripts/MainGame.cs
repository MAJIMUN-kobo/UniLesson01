using UnityEngine;

public class MainGame : MonoBehaviour
{
    public int clickCounter = 0;    // �J�E���g��ێ�����ϐ�

    void Start()
    {
        clickCounter = 0;

        Debug.Log("Click Coint = " + clickCounter); // �R���\�[���ɃJ�E���g��\������
    }

    void Update()
    {
        // �N���b�N������ƃJ�E���g��������
        if (Input.GetMouseButtonDown(0) == true)
        {
            clickCounter = clickCounter + 1;

            Debug.Log("Click Coint = " + clickCounter); // �R���\�[���ɃJ�E���g��\������
        }
    }
}
