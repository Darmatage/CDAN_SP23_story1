  using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4aDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		public Text Char3speech;
        public GameObject DialogueDisplay;
		
		public GameObject ArtChar1a;
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
		public GameObject ArtChar2a;
		public GameObject ArtChar2b;
		
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
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
	    ArtChar2a.SetActive(false);
		ArtChar2b.SetActive(false);
		
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
		DialogueDisplay.SetActive(true);
		
        }
        else if (primeInt == 2){
			   ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "WOWIE!  Bet a lot of human people died here!  Let’s go inside!";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt ==3){
				ArtChar1a.SetActive(false);
				ArtChar1c.SetActive(true);
                Char1name.text = "NARRATOR";
                Char1speech.text = "*You go inside the shipwreck*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
		   		ArtChar1a.SetActive(true);
				ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Wow, I'm totally blind in here";
				Char3name.text = "";
				Char3speech.text = "";
	   }
				
	   else if (primeInt == 5){
		   		ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Faceless Voice";
				Char3speech.text = "Hi Totally Blind in Here, I’m Dad!";
        }
       else if (primeInt == 6){
				ArtChar1b.SetActive(true);
				ArtChar1a.SetActive(false);
				ArtChar2a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "D-Dad?";
				Char3name.text = "";
				Char3speech.text = "";
				
				}
       else if (primeInt == 7){
				ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Dad";
				Char3speech.text = "Hey there kiddo.";
				
				}
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Dad";
				Char3speech.text = "I know we sort of left things off on a bad note...";
				
				}
       else if (primeInt == 9){
				ArtChar1b.SetActive(true);
				ArtChar2a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "A bad note?";
				Char3name.text = "";
				Char3speech.text = "";
				
				}
       else if (primeInt == 10){
				ArtChar1b.SetActive(false);
				ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "A BAD NOTE??";
				Char3name.text = "";
				Char3speech.text = "";
				
				}
       else if (primeInt == 11){
				ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Dad";
				Char3speech.text = "Son-";
				
				}
       else if (primeInt == 12){
				ArtChar1c.SetActive(true);
				ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "No- It wasn't just a bad note...";
				Char3name.text = "";
				Char3speech.text = "";
				
				}
       else if (primeInt == 13){
                Char1name.text = "NARRATOR";
                Char1speech.text = "*... This is really awkward*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				nextButton.SetActive(false);
				Choice1a.SetActive (true);
				Choice1b.SetActive (true);
                //gameHandler.AddPlayerStat(1);
      
        }

	 // after choice 1a
       else if (primeInt == 20){
		   ArtChar2a.SetActive(false);
		   ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Yeah... I'd like that.";
				Char3name.text ="";
				Char3speech.text = "";
	
	    }
	   else if (primeInt == 21){
		   ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Dad";
				Char3speech.text = "But Fish-";
				
				}
       else if (primeInt == 22){
				ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "We can talk about this later. We have a party to plan. Seafloor or reef?";
				Char3name.text = "";
				Char3speech.text = "";
				nextButton.SetActive(false);
				NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
            

		}

	 
	 // after choice 1b
       else if (primeInt == 38){
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Right... This is my dad. Or so I thought.";
				Char3name.text = "";
				Char3speech.text = "";
				
        }
		else if (primeInt == 39){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Turns out, I'm adopted.";
				Char3name.text ="";
				Char3speech.text = "";
		}
		
       else if (primeInt == 40){
				ArtChar2a.SetActive(true);
				ArtChar1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Dad";
				Char3speech.text = "Yes, Fish is adopted, but that doesn't make us any less of a family!";
				
				}
       else if (primeInt == 41){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Dad";
				Char3speech.text = "When I rescued your little egg from that murderous annemmm- anememem- ana-";
				
				}
       else if (primeInt == 42){
				ArtChar2a.SetActive(true);
				ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Anemone.";
				Char3name.text = "";
				Char3speech.text = "";
				
				}
       else if (primeInt == 43){
				ArtChar2a.SetActive(true);
				ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Dad";
				Char3speech.text = "Yes! When I saved you I promised to love and protect you for the rest of my life. You really are my son Fish.";
				
				}
       else if (primeInt == 44){
				ArtChar1b.SetActive(true);
				ArtChar1c.SetActive(false);
				ArtChar2a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Oh really? Am I? You didn't seem to know the difference between your son and my identical-long-lost-brother Foosh!";
				Char3name.text = "";
				Char3speech.text = "";
				
				}
       else if (primeInt == 45){
				ArtChar1b.SetActive(false);
				ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Dad";
				Char3speech.text = "His mustache was very convincing!";
				
				}
       else if (primeInt == 46){
				ArtChar1b.SetActive(true);
				ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "I don't have a mustache, JOHN!!!";
				Char3name.text = "";
				Char3speech.text = "";
				
				}
       else if (primeInt == 47){
				ArtChar1b.SetActive(false);
				ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Dad";
				Char3speech.text = "Fish I- Well I- How could you-";
				
				}
       else if (primeInt == 48){
				ArtChar1c.SetActive(true);
				ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Come on friend, parties are no place for this sort of treachery and betrayal. To the seafloor or reef?";
				Char3name.text = "";
				Char3speech.text = "";
				
				}
       else if (primeInt == 49){
                Char1name.text = "NARRATOR";
                Char1speech.text = "*the air seems tense.*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				
				}
       else if (primeInt == 50){
				ArtChar1b.SetActive(false);
				ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Dad";
				Char3speech.text = "My name isn't John...";
				nextButton.SetActive(false);
				NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
	 

		   
		
	// final scene selection
       else if (primeInt == 60){
		   ArtChar2a.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "How about the seafloor?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		
		 else if (primeInt == 61){
			ArtChar2a.SetActive(false);
			ArtChar2b.SetActive(false);
                Char1name.text = "You";
                Char1speech.text = "Let's check out the reef!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		 }
				
		else if (primeInt == 61){
			ArtChar2a.SetActive(false);
			ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = (false);
				NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
		}
		
		
		
	// do not delete the most holy bracket:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Yeah... I'd like that.";
				Char3name.text = "";
				Char3speech.text = "";
                primeInt = 20;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Right... This is my dad. Or so I thought.";
				Char3name.text = "";
				Char3speech.text = "";
                primeInt = 38;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;

        
        }



        public void SceneChange1(){
               SceneManager.LoadScene("Scene5a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene5b");
        }
}

