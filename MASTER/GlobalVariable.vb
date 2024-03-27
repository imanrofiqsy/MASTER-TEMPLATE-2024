Module GlobalVariable
    Public UserLevel As Integer
    Public LoadingBarValue As Integer
    Public LoadingBarMessage As String
    Public PlcTrigger As Boolean
    Public SetCylinder As Cylinder
    Public GetCylinder As Cylinder
    Public Structure Cylinder
        Dim TurnTable As Integer
        Dim V101 As Integer
        Dim V102 As Integer
    End Structure
    Public Structure MachineConfig
        Dim IP As String
        Dim Port As String
    End Structure
End Module
