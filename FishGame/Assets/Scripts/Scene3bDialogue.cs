using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Fish;
        public Text Char1speech;
        public Text Worm;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

     // Find the gameHandler:
     // gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       next();
                }
        }
   }

//Story Units! This is the main story function. Players hit [NEXT] to progress to the next primeInt:
public void next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Fish.text = "";
                Char1speech.text = "";
                Worm.text = "Jeda";
                Char2speech.text = "Wakey wakey, human.";
        }
       else if (primeInt ==3){
                Fish.text = "YOU";
                Char1speech.text = "Wuh..? What happened?";
                Worm.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Fish.text = "";
                Char1speech.text = "";
                Worm.text = "Jeda";
                Char2speech.text = "I know I did not hit you that hard.";
        }
       else if (primeInt == 5){
                Fish.text = "YOU";
                Char1speech.text = "Hit me? Why?";
                Worm.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Fish.text = "";
                Char1speech.text = "";
                Worm.text = "Jeda";
                Char2speech.text = "I am searching for a fugitive. Ragu Fahn.";
        }
       else if (primeInt ==7){
                Fish.text = "YOU";
                Char1speech.text = "Why do you think I know anything?";
                Worm.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Fish.text = "";
                Char1speech.text = "";
                Worm.text = "Jeda";
                Char2speech.text = "Do not play the stupid. You will take me to him.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Fish.text = "";
                Char1speech.text = "";
                Worm.text = "Jeda";
                Char2speech.text = "Then you are no use to me, and must be silenced.";
        }
       else if (primeInt == 101){
                Fish.text = "";
                Char1speech.text = "";
                Worm.text = "Jeda";
                Char2speech.text = "Come back here! Do not think you can hide from me!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Fish.text = "";
                Char1speech.text = "";
                Worm.text = "Jeda";
                Char2speech.text = "Do not think you can fool me, human. Where will we find him?";
        }
       else if (primeInt == 201){
                Fish.text = "YOU";
                Char1speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
                Worm.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

      //Please do NOT delete this MOST HOLY bracket that ends the next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Fish.text = "YOU";
                Char1speech.text = "I don't know what you're talking about!";
                Worm.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Fish.text = "YOU";
                Char1speech.text = "Sure, anything you want... just lay off the club.";
                Worm.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}