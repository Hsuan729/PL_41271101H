using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Waka
{
    /// <summary>
    /// NPC 資料
    /// </summary>
    [CreateAssetMenu(menuName = "Waka/NPC")]
    public class DataNPC : ScriptableObject 
    {
        [Header("NPC AI　要分析的句子")]
        public string[] sentences;
    }
}