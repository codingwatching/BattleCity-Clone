﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace SceneEvents
{
    public class MenuPlayGameSceneEvent : SceneEvent
    {
        [SerializeField] private string _firstLevelScene = "level01";

        public override void TriggerEvent()
        {
            base.TriggerEvent();

            SceneManager.LoadScene(_firstLevelScene);
        }
    }
}
