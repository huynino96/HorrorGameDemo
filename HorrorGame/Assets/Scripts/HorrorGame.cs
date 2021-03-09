using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HorrorGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    State state;
    
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        

    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }
    private void ManageState()
    {
        var nextStates = state.GetNextState();
        
        for (int i = 0; i < nextStates.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
                Debug.Log(state);
               
            }
            else if (Input.GetKeyDown(KeyCode.Backspace))
            {
                state = nextStates[nextStates.Length - 1];
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            state = startingState;
        }
        textComponent.text = state.GetStateStory();
    }
}
