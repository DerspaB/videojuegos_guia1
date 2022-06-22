using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasnformadas : MonoBehaviour
{

    public GameObject character;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RotateLeft()
    {
        character.transform.Rotate(0.0f, 10.0f, 0.0f, Space.Self);

    }
    public void RotateRight()
    {
        character.transform.Rotate(0.0f, -10.0f, 0.0f, Space.Self);

    }

    public void TranslateUp()
    {
        character.transform.Translate(Vector3.up * Time.deltaTime * 10, Space.World);

    }
    public void TranslateDown()
    {
        character.transform.Translate(Vector3.down * Time.deltaTime * 10, Space.World);

    }
    public void TranslateLeft()
    {
        character.transform.Translate(Vector3.left * Time.deltaTime * 10, Space.World);

    }
    public void TranslateRight()
    {
        character.transform.Translate(Vector3.right * Time.deltaTime * 10, Space.World);

    }
    public void Scale(float magnitud)
    {
        Vector3 changerscale = new Vector3(magnitud, magnitud, magnitud);
        character.transform.localScale += changerscale;

    }
}
