using UnityEngine;

public class Handler : MonoBehaviour
{
    private Attack_Manager attackManagerScript;

    private void Start()
    {
        attackManagerScript = GetComponent<Attack_Manager>();
    }

    public void HandleMessage(string messageJSON)
    {
        Json_Form message = JsonUtility.FromJson<Json_Form>(messageJSON);
        if (message.message == null) attackManagerScript.AddAttackQueue(message);
        else Debug.Log(message.message);
    }
}
