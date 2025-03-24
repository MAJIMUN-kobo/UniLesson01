using UnityEngine;

public class MainGame : MonoBehaviour
{
    public int clickCounter = 0;    // カウントを保持する変数

    void Start()
    {
        clickCounter = 0;

        Debug.Log("Click Coint = " + clickCounter); // コンソールにカウントを表示する
    }

    void Update()
    {
        // クリックをするとカウントが増える
        if (Input.GetMouseButtonDown(0) == true)
        {
            clickCounter = clickCounter + 1;

            Debug.Log("Click Coint = " + clickCounter); // コンソールにカウントを表示する
        }
    }
}
