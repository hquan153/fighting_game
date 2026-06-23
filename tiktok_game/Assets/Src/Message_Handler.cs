using UnityEngine;

public class Message_Handler : MonoBehaviour
{
    private Attack_Manager attackManagerScript;

    private void Start()
    {
        attackManagerScript = GetComponent<Attack_Manager>();
    }

    public void HandleMessage(string messageJSON)
    {
        Json_Form message = JsonUtility.FromJson<Json_Form>(messageJSON);
        if (message.message == null)
        {
            attackManagerScript.AddAttackQueue(message);
            Debug.Log(message.id + " x" + message.count + ", attacker: " + message.attacker + " ");
        }
        else Debug.Log(message.message);
    }
}
