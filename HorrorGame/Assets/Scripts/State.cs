using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story")]
public class State : ScriptableObject
{
    [TextArea(14, 10)] [SerializeField] string storyText;
    [SerializeField] State[] nextState;
    [SerializeField] List<State> previousState = new List<State>();

    // Start is called before the first frame update
    public string GetStateStory()
    {
        return storyText;
    } 

    public List<State> GetPreviousState()
    {
        return previousState;
    }

    public State[] GetNextState()
    {
        return nextState;
    }

}
