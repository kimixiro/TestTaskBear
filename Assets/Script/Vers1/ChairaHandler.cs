using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairaHandler : MonoBehaviour
{
    public List<Chair> chairs;
    
    public List<BotAI> botAis;
    public int lastSpawnPointIndex;
    
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            MoveBot();
        }
    }
    
    private void MoveBot()
    {
        SetDefaultChairBooked();
        for (int i = 0; i < botAis.Count; i++)
        {
            var b = botAis[i];
            Vector3 spawnPoint = GetNextSpawnPoint(b.lastPointIndex);
            b.Move(spawnPoint,lastSpawnPointIndex);
        }
    }
    
    private Vector3 GetNextSpawnPoint(int pointIndex)
    {
        int index  = (pointIndex + Random.Range(1, chairs.Count - 1)) % chairs.Count;
        
        while (chairs[index].booked)
        {
            index = (pointIndex + Random.Range(1, chairs.Count - 1)) % chairs.Count;
        }
        
        lastSpawnPointIndex = index;
        Vector3 t = chairs[index].pos;
        Vector3 v = new Vector3(t.x,0,t.z);
        chairs[index].booked = true;
        return v;
    }

    private void SetDefaultChairBooked()
    {
        for (int i = 0; i < chairs.Count; i++)
        {
            chairs[i].booked = false;
        }
    }
}
