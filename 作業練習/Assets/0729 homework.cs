using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    #region 欄位
    [Header("攻擊力"), Range(0, 1000)]
    private int ATK = 200;
    [Header("防禦力"), Range(0, 1000)]
    private int DEF = 200;
    [Header("血量"), Range(0, 500)]
    private int HP = 500;
    [Header("魔力"), Range(0, 200)]
    private int MP = 150;
    [Header("初級治癒術")]
    private string Lesserheal;
    [Header("初級治癒術消耗"), Range(0, 200)]
    private int MP1 = 40;
    [Header("中級治癒術")]
    private string Midheal;
    [Header("中級治癒術消耗"), Range(0, 200)]
    private int MP2 = 99;
    [Header("死亡與否")]
    private bool Deadornot = true;
    [Header("移動速度"), Range(0, 2)]
    private float Speed = 1;
    #endregion

    #region 方法
    private void Start()
    {
        Move();
        Lesserhealmethod();
        Midhealmethod();
        Hit();
        Dead();
        Attack();
    }
   
    



    private void Move()
    {
        print("移動");
    }
    private void Lesserhealmethod()
    { 
    }
    private void Midhealmethod()
    { 
    }
    private void Hit()
    {
    }
    private void Dead()
    { 
    }
    private void Attack()
    { 
    }
    #endregion


}
