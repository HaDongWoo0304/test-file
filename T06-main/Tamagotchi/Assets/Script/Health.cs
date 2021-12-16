using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public Image currentHappy;
    public Image currentHygiene;
    public Image currentHunger;
    public Image currentSleep;

    public Text HappyText;
    public Text HygieneText;
    public Text HungerText;
    public Text SleepText;

    private float happiness = 100;
    private float hygiene = 100;
    private float hunger = 100;
    private float sleep = 100;
    private float max = 100;

    public Button feeding;
    public Button bath;
    public Button sleeping;


    private void Start()
    {
        Button bt1 = feeding.GetComponent<Button>();
        bt1.onClick.AddListener(feedingPet);
        bt1.onClick.AddListener(playingPet);

        Button bt2 = bath.GetComponent<Button>();
        bt2.onClick.AddListener(cleaningPet);
        bt2.onClick.AddListener(playingPet);

        Button bt3 = sleeping.GetComponent<Button>();
        bt3.onClick.AddListener(sleepingPet);
        bt3.onClick.AddListener(playingPet);

        UpdateHappy();
        UpdateHunger();
        UpdateHygiene();
        UpdateSleep();

        Update();
    }


   private void Update()
    {
        happiness -= 5.5f * Time.deltaTime;
        if(happiness < 0)
        {
            happiness = 0;
        } 

        hunger -= 6f * Time.deltaTime;
        if(hunger < 0)
        {
            hunger = 0;
        } 
        
        sleep-= 5.7f * Time.deltaTime;
        if(sleep < 0)
        {
            sleep = 0;
        } 
        hygiene-= 5.75f * Time.deltaTime;
        if(hygiene < 0)
        {
            hygiene = 0;
        } 

        UpdateHappy();
        UpdateHunger();
        UpdateHygiene();
        UpdateSleep();
    }



    private void UpdateHunger(){
        float ratio = hunger / max;
        currentHunger.rectTransform.localScale = new Vector3(ratio,1,1);
        HungerText.text = (ratio*100).ToString("0")+"%";

    }
    
    private void UpdateHappy(){

        float ratio = happiness / max;
        currentHappy.rectTransform.localScale = new Vector3(ratio,1,1);
        HappyText.text = (ratio*100).ToString("0")+"%";
        
    }
    private void UpdateHygiene(){

        float ratio = hygiene / max;
        currentHygiene.rectTransform.localScale = new Vector3(ratio,1,1);
        HygieneText.text = (ratio*100).ToString("0")+"%";
        

    }
    private void UpdateSleep(){
        float ratio = sleep / max;
        currentSleep.rectTransform.localScale = new Vector3(ratio,1,1);
        SleepText.text = (ratio*100).ToString("0")+"%";
        

    }

    void feedingPet(){
        hunger += 15;
        if (hunger  > max){
            hunger = max;
        }
        UpdateHunger();


    }
    void cleaningPet(){
        hygiene += (max - hygiene);
        if (hygiene  > max){
            hygiene = max;
        }
        UpdateHygiene();
    }
    void sleepingPet(){
        sleep += 15;
        if (sleep  > max){
            sleep = max;
        }
        UpdateSleep();

    }
    void playingPet(){        
        happiness += 30;
        if (happiness  > max){
            happiness = max;
        }
        UpdateHappy();

    }
}

