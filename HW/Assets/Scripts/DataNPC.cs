using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Waka
{
    /// <summary>
    /// NPC ���
    /// </summary>
    [CreateAssetMenu(menuName = "Waka/NPC")]
    public class DataNPC : ScriptableObject 
    {
        [Header("NPC AI�@�n���R���y�l")]
        public string[] sentences;
    }
}