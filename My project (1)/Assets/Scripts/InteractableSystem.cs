﻿using UnityEngine;

namespace KID
{
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;

        private string nameTarget = "PlayerCapsule";

        private void OnTriggerEnter(Collider other)
        {
            print(other.name);
        }

        private void OnTriggerExit(Collider other)
        {
            
        }

        private void OnTriggerStay(Collider other)
        {
            
        }
    }
}