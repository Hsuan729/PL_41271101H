using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Waka 
{
    /// <summary>
    /// NPC ���
    /// </summary>
    public class NPCcontroller : MonoBehaviour 
    {
        // �ǦC�����
        [SerializeField, Header("NPC ���")]
        private DataNPC dataNPC;

        // Unity ���ʵe���
        private Animator ani;
        //����ƥ�:����C���ɷ|����@��
        private void Awake()
        {
           //��oNPC���W�����
            ani = GetComponent<Animator>();
        }


    }
}
