using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Waka 
{
    /// <summary>
    /// NPC 資料
    /// </summary>
    public class NPCcontroller : MonoBehaviour 
    {
        // 序列化欄位
        [SerializeField, Header("NPC 資料")]
        private DataNPC dataNPC;

        // Unity 的動畫控制器
        private Animator ani;
        //喚醒事件:播放遊戲時會執行一次
        private void Awake()
        {
           //獲得NPC身上的控制器
            ani = GetComponent<Animator>();
        }


    }
}
