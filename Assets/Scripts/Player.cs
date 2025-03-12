using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    // === �t�B�[���h
    // �ϐ��̐錾�y�A�N�Z�X���x�� �f�[�^�^ �ϐ��� = �l;�z
    public int HitPoint       = 10;
    public int MaxHitPoint    = 10;
    public string PlayerName  = "Kawakami";
    public Rigidbody2D MyBody = null;

    // �X�^�[�g���Ɉ�x�����X�V���s�����\�b�h
    void Start()
    {
        // �ϐ��̏���������
        // �ϐ��̕ύX�y�ϐ��� = �l�z���ϐ���錾���Ă���K�v������܂��B
        HitPoint = 10;
        MaxHitPoint = 10;
        PlayerName = "Kawakami";
    }

    // �Đ����Ɂu�����Ɓv�X�V���s�����\�b�h
    void Update()
    {
        if( Input.GetKeyDown( KeyCode.Return ) )
        {
            Debug.Log( "�G���^�[�L�[��������܂����I�I" );

            HitPoint = HitPoint - 1;
            //HitPoint -= 1;
            //HitPoint--;

            MyBody.AddForce( new Vector3( 0, 250, 0 ) );
            Debug.Log($"{ PlayerName } >> HP[ { HitPoint } / { MaxHitPoint } ]");
        }
    }
}
