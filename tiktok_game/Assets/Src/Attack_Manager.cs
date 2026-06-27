using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Attack_Manager : MonoBehaviour
{
    private GameObject ronaldoObject;
    private GameObject messiObject;

    private Player ronaldoScript;
    private Player messiScript;

    private Sound_Effect soundEffectScript;

    private readonly Queue<Json_Form> attackQueue = new();

    private bool isAttacking = false;

    private void Awake()
    {
        ronaldoObject = GameObject.Find("Players/Ronaldo");
        messiObject = GameObject.Find("Players/Messi");

        ronaldoScript = ronaldoObject.GetComponent<Player>();
        messiScript = messiObject.GetComponent<Player>();

        soundEffectScript = GameObject.FindGameObjectWithTag("Sound Effect").GetComponent<Sound_Effect>();
    }

    private void Update()
    {
        if (attackQueue.Count > 0 && !isAttacking)
        {
            Json_Form nextAttacker = attackQueue.Dequeue();
            StartCoroutine(ExecuteAttackRoutine(nextAttacker));
        }
    }

    private IEnumerator ExecuteAttackRoutine(Json_Form message)
    {
        isAttacking = true;
        soundEffectScript.StopBonk();
        soundEffectScript.PlayBonk();

        if (message.attacker == "Ronaldo")
        {
            ronaldoScript.Attack();
            messiScript.Damaged(message.damage);
        }
        else if (message.attacker == "Messi")
        {
            messiScript.Attack();
            ronaldoScript.Damaged(message.damage);
        }

        yield return new WaitForSeconds(ronaldoScript.restTime);

        isAttacking = false;
        soundEffectScript.StopBonk();
    }

    public void AddAttackQueue(Json_Form message)
    {
        for (int i = 0; i < message.count; i++)
        {
            attackQueue.Enqueue(message);
        }
    }
}