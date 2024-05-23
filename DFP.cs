{
  "resourceType": "Bundle",
  "id": "adae16f5-40c5-4392-9ad7-117185040469",
  "meta": {
    "lastUpdated": "2024-05-23T14:09:09.317+08:00"
  },
  "type": "searchset",
  "total": 1,
  "link": [ {
    "relation": "self",
    "url": "https://fhir.tcumi.com:58443/r5/fhir/Observation?subject=6387"
  } ],
  "entry": [ {
    "fullUrl": "https://fhir.tcumi.com:58443/r5/fhir/Observation/6388",
    "resource": {
      "resourceType": "Observation",
      "id": "6388",
      "meta": {
        "versionId": "1",
        "lastUpdated": "2024-05-23T14:08:43.832+08:00",
        "source": "#vevCfvzWQyylm4ae"
      },
      "status": "final",
      "category": [ {
        "coding": [ {
          "system": "http://terminology.hl7.org/CodeSystem/observation-category",
          "code": "vital-signs",
          "display": "Vital Signs"
        } ],
        "text": "Vital Signs"
      } ],
      "code": {
        "coding": [ {
          "system": "http://loinc.org",
          "code": "8480-6",
          "display": "Systolic blood pressure"
        } ],
        "text": "Systolic Blood Pressure"
      },
      "subject": {
        "reference": "Patient/6387"
      },
      "effectiveDateTime": "2024-05-23",
      "valueQuantity": {
        "value": 122,
        "unit": "mmHg",
        "system": "http://unitsofmeasure.org",
        "code": "mm[Hg]"
      }
    },
    "search": {
      "mode": "match"
    }
  } ]
}
