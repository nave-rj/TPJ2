# AV2 (3pts)

## PropertyDrawer de Tags

Criar o `TagSelectorDrawer`.

Trabalho conterá:
- Um MonoBehaviour com um campo `string myTag`;
- `TagSelectorAttribute`
- `TagSelectorDrawer` (dentro de uma pasta `Editor`)

Ao invés de aparecer um campo texto, é um menu popup (também conhecido como dropdown ou seletor) com as tags da Unity pra escolher.
(`EditorGUI.Popup(...);`)

## Extras

Não dar erro caso use o atributo em fields de outro tipo (que nao seja string)
Fazer o LayerSelector PropertyDrawer

## Dicas

```csharp
// Acessa as tags definidas na Unity
UnityEditorInternal.InternalEditorUtility.tags;

// Desenha um campo seletor (dropdown)
EditorGUI.Popup( position, label.text, opcoes );

// Pega o índice de um elemento num array
Array.IndexOf( array, elemento );

// property é o SerializedProperty que já vem no OnGUI
// Essa linha abaixo pega o valor da string contido na propriedade (no caso, a string do campo da tag)
property.stringValue // valor da tag
```

## Referências
- [PropertyDrawer](https://docs.unity3d.com/ScriptReference/PropertyDrawer.html)

## Logística
- Grupos de 2 a 4 pessoas
- Enviar para mlr@cesar.org.br
- Assunto: "AV1 3bi 3003"
- Nome do grupo no email
- Apenas um ema
