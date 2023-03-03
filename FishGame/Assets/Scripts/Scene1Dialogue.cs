using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
       public Animator anim;
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
       public GameObject ArtCharBOOM;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject Choice3a;
        public GameObject Choice3b;		
		
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
        public GameObject nextButton;
       public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){
	anim = ArtCharBOOM.GetComponent<Animator>();
	
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		 ArtChar1b.SetActive(false);
		  ArtChar1c.SetActive(false);
		   ArtChar1d.SetActive(false);
		    ArtChar1e.SetActive(false);
			ArtCharBOOM.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);		
	    Choice3a.SetActive(false);
        Choice3b.SetActive(false);	
		
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
                Char1speech.text = "Woah!  You are one weeeeird fish!!";
                // Char2name.text = "";
                // Char2speech.text = "";
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
                // Char2name.text = "";
                // Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
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
                // Char2name.text = "";
                // Char2speech.text = "";
				    nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }


       else if (primeInt == 200){
                Char1name.text = "Fish";
                Char1speech.text = "It'll be fun!";
                // Char2name.text = "";
                // Char2speech.text = "D";
        }
       else if (primeInt == 201){
                Char1name.text = "Fish";
                Char1speech.text = "Pretty please?  You wont regret it!";
                // Char2name.text = "";
                // Char2speech.text = "";
                 nextButton.SetActive(false);
                 allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct()
                Choice2b.SetActive(true); // function Choice2bFunct()
				}
				
				
		//choice #2

      else if (primeInt == 300){
                Char1name.text = "Fish";
                Char1speech.text = "Yay! So glad you changed your mind."; 
                // Char2name.text = "";
                // Char2speech.text = "";
				    nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
       else if (primeInt == 301){
                Char1name.text = "where should we look first?";
                Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
				NextScene2Button.SetActive(true);
        }


       else if (primeInt == 400){
                Char1name.text = "Fish";
                Char1speech.text = "There will be bumpin music!";
                // Char2name.text = "";
                // Char2speech.text = "";
        }
       else if (primeInt == 401){
                Char1name.text = "Fish";
                Char1speech.text = "And snacks!";
                // Char2name.text = "";
                // Char2speech.text = "";
        }
       else if (primeInt == 402){
                Char1name.text = "Fish";
                Char1speech.text = "And friendly friends all around!!";
                // Char2name.text = "";
                // Char2speech.text = "";
        }
       else if (primeInt == 403){
                Char1name.text = "Fish";
                Char1speech.text = "Whatcha say?";
                // Char2name.text = "";
                // Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice3a.SetActive(true); // function Choice2aFunct()
                Choice3b.SetActive(true); // function Choice2bFunct()
				
				}

		
	//choice #3
      else if (primeInt == 500){
                Char1name.text = "Fish";
                Char1speech.text = "WHEW. I'm so glad!";
                // Char2name.text = "";
                // Char2speech.text = "";

        }
		      else if (primeInt == 501){
                Char1name.text = "Fish";
                Char1speech.text = "I mean, only if YOU want to.";
                // Char2name.text = "";
                // Char2speech.text = "";

        }
		      else if (primeInt == 502){
                Char1name.text = "Fish";
                Char1speech.text = "Where should we look first?";
                // Char2name.text = "";
                // Char2speech.text = "";

        }
		
       else if (primeInt == 503){
                Char1name.text = "";
                Char1speech.text = "";
                // Char2name.text = "";
                // Char2speech.text = ";
				    nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }


       else if (primeInt == 600){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(false);
		   ArtChar1c.SetActive(false);
		   ArtChar1d.SetActive(false);
		   ArtChar1e.SetActive(true);
                Char1name.text = "Fish";
                Char1speech.text = "And..  And...  It's party time...";
                // Char2name.text = "Jeda";
                // Char2speech.text = "Do not think you can fool me, human. Where will we find him?";
        }
       else if (primeInt == 601){
                Char1name.text = "Fish";
                Char1speech.text = "Party...";
                // Char2name.text = "";
                // Char2speech.text = "";
				//instantiate explosion
				}
       else if (primeInt == 602){
		   DialogueDisplay.SetActive(false);
		   ArtChar1e.SetActive(false);
		   ArtCharBOOM.SetActive(true);
		   anim.SetTrigger("Boom");
		SceneManager.LoadScene("End_Lose");
			//image of bits of floating fish

	   }

      else if (primeInt == 603){
                Char1name.text = "";
                Char1speech.text = "";
				nextButton.SetActive(false);
				NextScene3Button.SetActive(true);
		SceneManager.LoadScene("End_Lose");
                // Char2name.text = "";
                // Char2speech.text = "";
        }
		
		
	
	//all important end of next() function bracket:	
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
                Char1speech.text = "Whaaat?  You don't mean that right?  You wanna come right?";
                // Char2name.text = "";
                // Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice2aFunct(){
                Char1name.text = "Fish";
                Char1speech.text = "Hooray!  You’re my first guest!  Let’s go find some more!";
                // Char2name.text = "";
                // Char2speech.text = "";
                primeInt = 299;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "Fish";
                Char1speech.text = "Come on now, it'll be really really fun!";
                // Char2name.text = "";
                // Char2speech.text = "";
                primeInt = 399;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice3aFunct(){
                Char1name.text = "Fish";
                Char1speech.text = "Hooray!  You’re my first guest!  Let’s go find some more!";
                // Char2name.text = "";
                // Char2speech.text = "";
                primeInt = 499;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice3bFunct(){
                Char1name.text = "Fish";
                Char1speech.text = "But why not?.. It’ll be oh so lonely if no one shows up";
                // Char2name.text = "";
                // Char2speech.text = "";
                primeInt = 599;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
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
                SceneManager.LoadScene("End_Lose1");
        }
}