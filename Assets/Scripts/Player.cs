using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    // === フィールド
    // 変数の宣言【アクセスレベル データ型 変数名 = 値;】
    public int HitPoint       = 10;
    public int MaxHitPoint    = 10;
    public string PlayerName  = "Kawakami";
    public Rigidbody2D MyBody = null;

    // スタート時に一度だけ更新を行うメソッド
    void Start()
    {
        // 変数の初期化処理
        // 変数の変更【変数名 = 値】※変数を宣言している必要があります。
        HitPoint = 10;
        MaxHitPoint = 10;
        PlayerName = "Kawakami";
    }

    // 再生中に「ずっと」更新を行うメソッド
    void Update()
    {
        if( Input.GetKeyDown( KeyCode.Return ) )
        {
            Debug.Log( "エンターキーが押されました！！" );

            HitPoint = HitPoint - 1;
            //HitPoint -= 1;
            //HitPoint--;

            MyBody.AddForce( new Vector3( 0, 250, 0 ) );
            Debug.Log($"{ PlayerName } >> HP[ { HitPoint } / { MaxHitPoint } ]");
        }
    }
}
