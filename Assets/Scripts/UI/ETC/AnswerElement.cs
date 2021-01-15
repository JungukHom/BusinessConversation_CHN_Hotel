﻿namespace BusinessConversation.CHN.Hotel
{
    // C#
    using System.Collections;
    using System.Collections.Generic;

    // Unity
    using UnityEngine;
    using UnityEngine.UI;

    // Project
    // Alias

    public class AnswerElement : MonoBehaviour
    {
        public Button btn_wrapperButton;
        public Text txt_answer;

        public AnswerPopup pnl_answerPopup;

        public Sprite sprite_o;
        public Sprite sprite_x;

        private AnswerDataOX answerDataOX;
        private AnswerDataMC answerDataMC;

        private int currentIndex = -1;

        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            SetListeners();
        }

        public void InitializeWith(AnswerDataOX data)
        {
            this.answerDataOX = data;

            SetAnswerText(data.playerAnswer);
            SetListeners();
        }

        public void InitializeWith(AnswerDataMC data)
        {
            this.answerDataMC = data;

            SetAnswerText(data.playerAnswer);
            SetListeners();
        }

        private void SetListeners()
        {
            btn_wrapperButton.onClick.AddListener(() => { OnWrapperButtonClicked(); });
        }

        public void SetAnswerText(string playerAnswer)
        {
            txt_answer.text = playerAnswer;
        }

        private void OnWrapperButtonClicked()
        {
            bool isOX = currentIndex < 3;

            if (pnl_answerPopup == null)
            {
                Debug.Log("null pnl_answerPopup");
            }

            if (answerDataOX == null)
            {
                Debug.Log("null answerDataOX");
            }

            if (answerDataMC == null)
            {
                Debug.Log("null answerDataMC");
            }

            pnl_answerPopup.gameObject.SetActive(true);

            if (isOX)
                pnl_answerPopup.InitializeWith(answerDataOX);
            else
                pnl_answerPopup.InitializeWith(answerDataMC);

            
        }
    }
}
