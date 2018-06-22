using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{
    public GameObject note;
    private float radius = 2;

    private void Start()
    {
        transform.localScale = new Vector3(radius * 2, radius * 2, 1);
        StartCoroutine("Spawn");
    }

    private IEnumerator Spawn()
    {
        int i = 0;
        while (i < 10)
        {
            GameObject newNote = Instantiate(note, new Vector2(transform.position.x, transform.position.y - radius), Quaternion.identity) as GameObject;
            newNote.transform.SetParent(transform, true);
            i++;
            yield return new WaitForSeconds(Random.Range(0.5f, 2));
        }
    }

    private void Update()
    {
        transform.Rotate(0, 0, 90 * Time.deltaTime);
    }
}