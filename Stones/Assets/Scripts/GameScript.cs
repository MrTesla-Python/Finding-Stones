using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class GameScript : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button stoneOne, stoneTwo, stoneThree, hint, yesButton, noButton, lilyPadButton, treeButton, whaleButton, soundButton, mutedButton;
    public GameObject stoneImageOne, stoneImageTwo, stoneImageThree, sheepImage;
    public TMP_Text allStonesFound, noStonesFound, sureHintText, hintText;
    private int textCounter = 0;
 
    void Start()
    {  
        stoneImageOne.SetActive(false);
        stoneImageTwo.SetActive(false);
        stoneImageThree.SetActive(false);
        allStonesFound.enabled = false;
        sureHintText.enabled = false;
        hintText.enabled = false;
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        sheepImage.gameObject.SetActive(true);
        mutedButton.gameObject.SetActive(false);
        stoneOne.onClick.AddListener(taskOnClickOne);
        stoneTwo.onClick.AddListener(taskOnClickTwo);
        stoneThree.onClick.AddListener(TaskOnClickThree);
        hint.onClick.AddListener(TaskOnClickHint);
        yesButton.onClick.AddListener(TaskOnClickYes);
        noButton.onClick.AddListener(TaskOnClickNo);
        lilyPadButton.onClick.AddListener(TaskOnClickRemoveLily);
        treeButton.onClick.AddListener(TaskOnClickRemoveTree);
        whaleButton.onClick.AddListener(TaskOnClickRemoveWhale);
        soundButton.onClick.AddListener(TaskOnClickSoundOff);
        mutedButton.onClick.AddListener(TaskOnClickSoundOn);
    }
   
    void taskOnClickOne()
    {  
        stoneImageOne.SetActive(true);
        textCounter ++;
        Debug.Log("Pressed");
        Destroy(stoneOne.gameObject);
        
    }
    void taskOnClickTwo()
    {
        stoneImageTwo.SetActive(true);
        textCounter ++;
        Debug.Log("Pressed");
        Destroy(stoneTwo.gameObject);
        
    }
    void TaskOnClickThree()
    {
        stoneImageThree.SetActive(true);
        textCounter ++;
        Debug.Log("Pressed");
        Destroy(stoneThree.gameObject);
    }
    void TaskOnClickHint()
    {
        sureHintText.enabled = true;
        yesButton.gameObject.SetActive(true);
        noButton.gameObject.SetActive(true);
        hintText.enabled = false;
    }
    void TaskOnClickYes()
    {
        hintText.enabled = true;
        sheepImage.gameObject.SetActive(true);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        sureHintText.enabled = false;
    }
    void TaskOnClickNo()
    {
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        sureHintText.enabled = false;
    }
    void TaskOnClickRemoveLily()
    {
        lilyPadButton.gameObject.SetActive(false);
    }
    void TaskOnClickRemoveTree()
    {
        treeButton.gameObject.SetActive(false);
    }
    void TaskOnClickRemoveWhale()
    {
        whaleButton.gameObject.SetActive(false);
    }
    void TaskOnClickSoundOff()
    {
        AudioListener.pause = true;
        mutedButton.gameObject.SetActive(true);
        soundButton.gameObject.SetActive(false);
    }
    void TaskOnClickSoundOn()
    {
        AudioListener.pause = false;
        soundButton.gameObject.SetActive(true);
        mutedButton.gameObject.SetActive(false);
    }
    void Update()
    {
        if (textCounter == 3)
        {
            noStonesFound.enabled = false;
            allStonesFound.enabled = true;
        }
       
    }
}


