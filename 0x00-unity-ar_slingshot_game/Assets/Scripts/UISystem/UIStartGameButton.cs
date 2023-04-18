﻿using EventNotifier;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UISystem
{
    public class UIStartGameButton : MonoBehaviour, IPointerUpHandler
    {
        public void OnPointerUp(PointerEventData eventData)
        {
            GameEvents.OnStartGameEvent();
            gameObject.SetActive(false);
        }
    }
}