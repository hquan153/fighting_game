using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.LowLevelPhysics2D.PhysicsLayers;

public class Handler : MonoBehaviour
{
    [SerializeField] private GameObject ronaldoObject;
    [SerializeField] private GameObject messiObject;

    private Sound soundComponent;

    private Player ronaldoScript;
    private Player messiScript;

    private void Awake()
    {
        soundComponent = GameObject.FindGameObjectWithTag("Sound").GetComponent<Sound>();

        ronaldoScript = ronaldoObject.GetComponent<Player>();
        messiScript = messiObject.GetComponent<Player>();
    }

    private void Update()
    {
        if (Keyboard.current?.aKey.wasPressedThisFrame == true)
        {
            PlayerAttack("Ronaldo");
        }
        else if (Keyboard.current?.dKey.wasPressedThisFrame == true)
        {
            PlayerAttack("Messi");
        }
    }

    private void PlayerAttack(string playerName, bool isRandom = false)
    {
        if (playerName == "Ronaldo" && isRandom == false)
        {
            ronaldoScript.Attack();
            messiScript.Damaged(0.1f);
        }
        else if (playerName == "Messi" && isRandom == false)
        {
            messiScript.Attack();
            ronaldoScript.Damaged(0.1f);
        }
        else
        {
            float randomNumber = Random.Range(-1f, 1f);
            if (randomNumber <= 0) PlayerAttack("Ronaldo");
            else PlayerAttack("Messi");
        }
        soundComponent.PlayBonk();
    }

    public void HandleMessage(string messageJSON)
    {
        Json_Form message = JsonUtility.FromJson<Json_Form>(messageJSON);

        PlayerAttack(message.attacker, message.isRandom);
    }
}
