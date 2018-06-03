using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CustomModel : MonoBehaviour {

    private GameObject m_instance = null;

    public GameObject m_model = null;
    public GameObject Model
    {
        get
        {
            return m_model;
        }

        set
        {
            if (m_instance != null)
                Destroy(m_instance);

            m_model = value;
            InitModel();
        }
    }

	// Use this for initialization
//  	void Start () {
//          InitModel();
//  	}

    public void InitModel()
    {
        m_instance = Instantiate(Model, gameObject.transform);
        //GetComponent<BoxCollider>().extents = m_instance.transform.boun
    }

//     public void OnValidate()
//     {
//         //Model = m_model;
//     }
}
