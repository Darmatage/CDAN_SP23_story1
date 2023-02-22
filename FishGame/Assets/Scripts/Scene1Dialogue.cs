using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        // public Text Char2name;
        // public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
       public GameObject ArtChar1d;
	   public GameObject ArtChar1e;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
        public GameObject nextButton;
       public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		 ArtChar1b.SetActive(false);
		  ArtChar1c.SetActive(false);
		   ArtChar1d.SetActive(false);
		    ArtChar1e.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
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
                Char1name.text = "Fish";
                Char1speech.text = "Wow!  You’re one weeeeird fish!!";
                // Char2name.text = "Jeda";
                // Char2speech.text = "Wakey wakey, human.";
        }
       else if (primeInt ==3){
		        ArtChar1a.SetActive(false);
		        ArtChar1b.SetActive(true);
                Char1name.text = "Fish";
                Char1speech.text = "My name’s Fish, wanna go party with me?";
                // Char2name.text = "";
                // Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
				      nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                // Char2name.text = "Jeda";
                // Char2speech.text = "I know I did not hit you that hard.";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Hit me? Why?";
                // Char2name.text = "";
                // Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                // Char2name.text = "Jeda";
                // Char2speech.text = "I am searching for a fugitive. Ragu Fahn.";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "Why do you think I know anything?";
                // Char2name.text = "";
                // Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                // Char2name.text = "Jeda";
                // Char2speech.text = "Do not play the stupid. You will take me to him.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "Fish";
                Char1speech.text = "Okay, where should we look first?";
                // Char2name.text = "Jeda";
                // Char2speech.text = "Then you are no use to me, and must be silenced.";
				    nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                // Char2name.text = "Jeda";
                // Char2speech.text = "Come back here! Do not think you can hide from me!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "Fish";
                Char1speech.text = "but… it’s party time..";
                // Char2name.text = "Jeda";
                // Char2speech.text = "Do not think you can fool me, human. Where will we find him?";
        }
       else if (primeInt == 201){
                Char1name.text = "Fish";
                Char1speech.text = "but… it’s party time..";
                // Char2name.text = "";
                // Char2speech.text = "";
                // nextButton.SetActive(false);
                // allowSpace = false;
                // NextScene2Button.SetActive(true);
				}
       else if (primeInt == 202){
                Char1name.text = "Fish";
                Char1speech.text = "....party?";
                // Char2name.text = "";
                // Char2speech.text = "";
                // nextButton.SetActive(false);
                // allowSpace = false;
                // NextScene3Button.SetActive(true);
				      // SceneManager.LoadScene("End_Lose");
					  }
       else if (primeInt == 203){
                // Char2name.text = "";
                // Char2speech.text = "";
                // nextButton.SetActive(false);
                // allowSpace = false;
                // NextScene3Button.SetActive(true);
				      SceneManager.LoadScene("End_Lose");
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "Fish";
                Char1speech.text = "Hooray!  You’re my first guest!  Let’s go find some more!";
                // Char2name.text = "";
                // Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "Fish";
                Char1speech.text = "why not? It’ll be so lonely if no one shows up";
                // Char2name.text = "";
                // Char2speech.text = "";
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
        public void SceneChange3(){
                SceneManager.LoadScene("End_Lose");
        }
}