
using System;
using System.Collections;
using UnityEngine;
namespace Assets.Scripts
{
[Serializable]
public class Person
{
public string fullname;
[SerializeField] private string firstName;
[SerializeField] private string lastName;
}
public class SchoolManager : MonoBehaviour
{
[Header("Reference to Manager")]
public Person principal;
public Person director;
[Space(30)]
[Header("Reference to Teaching fields")]
public Person[] teachers;
public Person[] students;
[UnityEngine.Range(1, 100)]
public int staff;
[TextArea]
public string description;
[Tooltip("Day la mo ta tom tat thong tin chi tiet ve ngoi truong")]
public string schoolNotes;
// Use this for initialization
void Start()
{
}
// Update is called once per frame
void Update()
{
}
}
}