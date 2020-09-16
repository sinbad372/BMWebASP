Public Class clsEmployee
    Private pEmpID As String
    Private pEmpName As String
    Private pEmpJob As String
    Private pEmpNationality As String
    Private pEmpNationalityAR As String
    Private pEmpNationalityEN As String
    Private pEmpMobile As String
    Private pEmpKafala As String
    Private pEmpIqama As String
    Private pEmpCompHiringDate As Date
    Private pEmpSuperHiringDate As Date
    Private pEmpSeniorHiringDate As Date
    Private pEmpDistrictHiringDate As Date
    Private pEmpDirectorHiringDate As Date
    Private pEmpTerminationDate As Date
    Private pEmpPassword As String
    Private pChkChanged As Boolean
    Private pMaritalMarried As Boolean
    Private pEmpNotes As String
    Private pDel As Boolean
    Private pChg As Boolean
    Private pAct As Boolean
    Private pInAct As Boolean
    Private pRowNotShow As Boolean
    Private pRowDateAdd As Date
    Private pRowDateModify As Date
    Private pRowEmpIDAdd As String
    Private pRowEmpIDModify As String
    Private pTbID As Long
    Private pEmpLocDate As Date
    Private pEmpJobType As String
    Private pLocPHN As String
    Private pRegionTeam As String
    Private pDirectorID As String
    Private pEmpNameDirector As String
    Private pDirectorArea As String
    Private pDistrictID As String
    Private pEmpNameDistrict As String
    Private pDistrictArea As String
    Private pSeniorID As String
    Private pEmpNameSenior As String
    Private pSeniorArea As String
    Private pSupervisorID As String
    Private pEmpNameSupervisor As String
    Private pSupervisorArea As String
    Private pServerNormalTotalHours As Double
    Private pServerFridayTotalHours As Double
    Private pServerTotalHours As Double
    Private pServerTotalDays As Double
    Private pEmpAlias As String
    Private pEmpSalary As Double
    Private pEmpNameMuqeem As String
    Private pEmpJobMuqeem As String
    Private pEmpKafalaMuqeem As String
    Private pEmpPassport As String
    Private pIBAN As String
    Private pEmpNameHR As String
    Private pUserLevel As String
    Private pCityRegion As String
    Private pCityArab As String

    Private pLocationNumbers As Long
    Private pLocationName As Dictionary(Of String, String)
    Private pLocationDatBegin As Dictionary(Of String, String)
    Private pLocationDatEnd As Dictionary(Of String, String)
    Private pLocationRegionTeam As Dictionary(Of String, String)
    Private pLocationNormalDays As Dictionary(Of String, String)
    Private pLocationFridayDays As Dictionary(Of String, String)
    Private pLocationDutyType As Dictionary(Of String, String)
    Private pLocationEmpLocDate As Dictionary(Of String, String)
    Private pLocationEmpJobType As Dictionary(Of String, String)
    Private pLocationEmpContractHNormal As Dictionary(Of String, String)
    Private pLocationEmpContractHFriday As Dictionary(Of String, String)
    Private pLocationEmpWeeklyVacation As Dictionary(Of String, String)
    Private pLocationEmpMonthlyFridayWork As Dictionary(Of String, String)
    Private pEmpFridayCount As Dictionary(Of String, String)
    Public Sub New()
        pLocationName = New Dictionary(Of String, String)
        pLocationDatBegin = New Dictionary(Of String, String)
        pLocationDatEnd = New Dictionary(Of String, String)
        pLocationRegionTeam = New Dictionary(Of String, String)
        pLocationNormalDays = New Dictionary(Of String, String)
        pLocationFridayDays = New Dictionary(Of String, String)
        pLocationDutyType = New Dictionary(Of String, String)
        pLocationEmpLocDate = New Dictionary(Of String, String)
        pLocationEmpJobType = New Dictionary(Of String, String)
        pLocationEmpContractHNormal = New Dictionary(Of String, String)
        pLocationEmpContractHFriday = New Dictionary(Of String, String)
        pLocationEmpWeeklyVacation = New Dictionary(Of String, String)
        pLocationEmpMonthlyFridayWork = New Dictionary(Of String, String)
        pEmpFridayCount = New Dictionary(Of String, String)
    End Sub
    Public Sub Clear()
        pEmpID = Nothing
        pEmpName = Nothing
        pEmpJob = Nothing
        pEmpNationality = Nothing
        pEmpNationalityAR = Nothing
        pEmpNationalityEN = Nothing
        pEmpMobile = Nothing
        pEmpKafala = Nothing
        pEmpIqama = Nothing
        pEmpCompHiringDate = Nothing
        pEmpSuperHiringDate = Nothing
        pEmpSeniorHiringDate = Nothing
        pEmpDistrictHiringDate = Nothing
        pEmpDirectorHiringDate = Nothing
        pEmpTerminationDate = Nothing
        pEmpPassword = Nothing
        pChkChanged = Nothing
        pMaritalMarried = Nothing
        pEmpNotes = Nothing
        pDel = Nothing
        pChg = Nothing
        pAct = Nothing
        pInAct = Nothing
        pRowNotShow = Nothing
        pRowDateAdd = Nothing
        pRowDateModify = Nothing
        pRowEmpIDAdd = Nothing
        pRowEmpIDModify = Nothing
        pTbID = Nothing
        pEmpLocDate = Nothing
        pEmpJobType = Nothing
        pLocPHN = Nothing
        pRegionTeam = Nothing
        pDirectorID = Nothing
        pEmpNameDirector = Nothing
        pDirectorArea = Nothing
        pDistrictID = Nothing
        pEmpNameDistrict = Nothing
        pDistrictArea = Nothing
        pSeniorID = Nothing
        pEmpNameSenior = Nothing
        pSeniorArea = Nothing
        pSupervisorID = Nothing
        pEmpNameSupervisor = Nothing
        pSupervisorArea = Nothing
        pServerNormalTotalHours = Nothing
        pServerFridayTotalHours = Nothing
        pServerTotalHours = Nothing
        pServerTotalDays = Nothing
        pEmpAlias = Nothing
        pEmpSalary = Nothing
        pEmpNameMuqeem = Nothing
        pEmpJobMuqeem = Nothing
        pEmpKafalaMuqeem = Nothing
        pEmpPassport = Nothing
        pIBAN = Nothing
        pEmpNameHR = Nothing
        pUserLevel = Nothing
        pCityRegion = Nothing
        pCityArab = Nothing
        pLocationNumbers = Nothing
        pLocationName.Clear()
        pLocationDatBegin.Clear()
        pLocationDatEnd.Clear()
        pLocationRegionTeam.Clear()
        pLocationNormalDays.Clear()
        pLocationFridayDays.Clear()
        pLocationDutyType.Clear()
        pLocationEmpLocDate.Clear()
        pLocationEmpJobType.Clear()
        pLocationEmpContractHNormal.Clear()
        pLocationEmpContractHFriday.Clear()
        pLocationEmpWeeklyVacation.Clear()
        pLocationEmpMonthlyFridayWork.Clear()
        pEmpFridayCount.Clear()
    End Sub
    Property EmpID() As String
        Get
            Return pEmpID
        End Get
        Set(value As String)
            pEmpID = value
        End Set
    End Property
    Property EmpName() As String
        Get
            Return pEmpName
        End Get
        Set(value As String)
            pEmpName = value
        End Set
    End Property
    Property EmpJob() As String
        Get
            Return pEmpJob
        End Get
        Set(value As String)
            pEmpJob = value
        End Set
    End Property
    Property EmpNationality() As String
        Get
            Return pEmpNationality
        End Get
        Set(value As String)
            pEmpNationality = value
        End Set
    End Property
    Property EmpNationalityAR() As String
        Get
            Return pEmpNationalityAR
        End Get
        Set(value As String)
            pEmpNationalityAR = value
        End Set
    End Property
    Property EmpNationalityEN() As String
        Get
            Return pEmpNationalityEN
        End Get
        Set(value As String)
            pEmpNationalityEN = value
        End Set
    End Property

    Property EmpMobile() As String
        Get
            Return pEmpMobile
        End Get
        Set(value As String)
            pEmpMobile = value
        End Set
    End Property
    Property EmpKafala() As String
        Get
            Return pEmpKafala
        End Get
        Set(value As String)
            pEmpKafala = value
        End Set
    End Property
    Property EmpIqama() As String
        Get
            Return pEmpIqama
        End Get
        Set(value As String)
            pEmpIqama = value
        End Set
    End Property
    Property EmpCompHiringDate() As Date
        Get
            Return pEmpCompHiringDate
        End Get
        Set(value As Date)
            pEmpCompHiringDate = value
        End Set
    End Property
    Property EmpSuperHiringDate() As Date
        Get
            Return pEmpSuperHiringDate
        End Get
        Set(value As Date)
            pEmpSuperHiringDate = value
        End Set
    End Property
    Property EmpSeniorHiringDate() As Date
        Get
            Return pEmpSeniorHiringDate
        End Get
        Set(value As Date)
            pEmpSeniorHiringDate = value
        End Set
    End Property
    Property EmpDistrictHiringDate() As Date
        Get
            Return pEmpDistrictHiringDate
        End Get
        Set(value As Date)
            pEmpDistrictHiringDate = value
        End Set
    End Property
    Property EmpDirectorHiringDate() As Date
        Get
            Return pEmpDirectorHiringDate
        End Get
        Set(value As Date)
            pEmpDirectorHiringDate = value
        End Set
    End Property
    Property EmpTerminationDate() As Date
        Get
            Return pEmpTerminationDate
        End Get
        Set(value As Date)
            pEmpTerminationDate = value
        End Set
    End Property
    Property EmpPassword() As String
        Get
            Return pEmpPassword
        End Get
        Set(value As String)
            pEmpPassword = value
        End Set
    End Property
    Property ChkChanged() As Boolean
        Get
            Return pChkChanged
        End Get
        Set(value As Boolean)
            pChkChanged = value
        End Set
    End Property
    Property Chg() As Boolean
        Get
            Return pChg
        End Get
        Set(value As Boolean)
            pChg = value
        End Set
    End Property

    Property MaritalMarried() As Boolean
        Get
            Return pMaritalMarried
        End Get
        Set(value As Boolean)
            pMaritalMarried = value
        End Set
    End Property

    Property EmpNotes() As String
        Get
            Return pEmpNotes
        End Get
        Set(value As String)
            pEmpNotes = value
        End Set
    End Property
    Property EmpLocDate() As Date
        Get
            Return pEmpLocDate
        End Get
        Set(value As Date)
            pEmpLocDate = value
        End Set
    End Property
    Property EmpJobType() As String
        Get
            Return pEmpJobType
        End Get
        Set(value As String)
            pEmpJobType = value
        End Set
    End Property
    Property LocPHN() As String
        Get
            Return pLocPHN
        End Get
        Set(value As String)
            pLocPHN = value
        End Set
    End Property
    Property RegionTeam() As String
        Get
            Return pRegionTeam
        End Get
        Set(value As String)
            pRegionTeam = value
        End Set
    End Property
    Property DirectorID() As String
        Get
            Return pDirectorID
        End Get
        Set(value As String)
            pDirectorID = value
        End Set
    End Property
    Property EmpNameDirector() As String
        Get
            Return pEmpNameDirector
        End Get
        Set(value As String)
            pEmpNameDirector = value
        End Set
    End Property
    Property DirectorArea() As String
        Get
            Return pDirectorArea
        End Get
        Set(value As String)
            pDirectorArea = value
        End Set
    End Property
    Property DistrictID() As String
        Get
            Return pDistrictID
        End Get
        Set(value As String)
            pDistrictID = value
        End Set
    End Property
    Property EmpNameDistrict() As String
        Get
            Return pEmpNameDistrict
        End Get
        Set(value As String)
            pEmpNameDistrict = value
        End Set
    End Property
    Property DistrictArea() As String
        Get
            Return pDistrictArea
        End Get
        Set(value As String)
            pDistrictArea = value
        End Set
    End Property
    Property SeniorID() As String
        Get
            Return pSeniorID
        End Get
        Set(value As String)
            pSeniorID = value
        End Set
    End Property
    Property EmpNameSenior() As String
        Get
            Return pEmpNameSenior
        End Get
        Set(value As String)
            pEmpNameSenior = value
        End Set
    End Property
    Property SeniorArea() As String
        Get
            Return pSeniorArea
        End Get
        Set(value As String)
            pSeniorArea = value
        End Set
    End Property
    Property SupervisorID() As String
        Get
            Return pSupervisorID
        End Get
        Set(value As String)
            pSupervisorID = value
        End Set
    End Property
    Property EmpNameSupervisor() As String
        Get
            Return pEmpNameSupervisor
        End Get
        Set(value As String)
            pEmpNameSupervisor = value
        End Set
    End Property
    Property SupervisorArea() As String
        Get
            Return pSupervisorArea
        End Get
        Set(value As String)
            pSupervisorArea = value
        End Set
    End Property
    Property ServerNormalTotalHours() As Double
        Get
            Return pServerNormalTotalHours
        End Get
        Set(value As Double)
            pServerNormalTotalHours = value
        End Set
    End Property
    Property ServerFridayTotalHours() As Double
        Get
            Return pServerFridayTotalHours
        End Get
        Set(value As Double)
            pServerFridayTotalHours = value
        End Set
    End Property
    Property ServerTotalHours() As Double
        Get
            Return pServerTotalHours
        End Get
        Set(value As Double)
            pServerTotalHours = value
        End Set
    End Property
    Property ServerTotalDays() As Double
        Get
            Return pServerTotalDays
        End Get
        Set(value As Double)
            pServerTotalDays = value
        End Set
    End Property
    Property EmpAlias() As String
        Get
            Return pEmpAlias
        End Get
        Set(value As String)
            pEmpAlias = value
        End Set
    End Property

    Property EmpNameMuqeem() As String
        Get
            Return pEmpNameMuqeem
        End Get
        Set(value As String)
            pEmpNameMuqeem = value
        End Set
    End Property

    Property EmpJobMuqeem() As String
        Get
            Return pEmpJobMuqeem
        End Get
        Set(value As String)
            pEmpJobMuqeem = value
        End Set
    End Property

    Property EmpKafalaMuqeem() As String
        Get
            Return pEmpKafalaMuqeem
        End Get
        Set(value As String)
            pEmpKafalaMuqeem = value
        End Set
    End Property

    Property EmpPassport() As String
        Get
            Return pEmpPassport
        End Get
        Set(value As String)
            pEmpPassport = value
        End Set
    End Property

    Property IBAN() As String
        Get
            Return pIBAN
        End Get
        Set(value As String)
            pIBAN = value
        End Set
    End Property

    Property EmpNameHR() As String
        Get
            Return pEmpNameHR
        End Get
        Set(value As String)
            pEmpNameHR = value
        End Set
    End Property

    Property UserLevel() As String
        Get
            Return pUserLevel
        End Get
        Set(value As String)
            pUserLevel = value
        End Set
    End Property
    Property CityRegion() As String
        Get
            Return pCityRegion
        End Get
        Set(value As String)
            pCityRegion = value
        End Set
    End Property
    Property CityArab() As String
        Get
            Return pCityArab
        End Get
        Set(value As String)
            pCityArab = value
        End Set
    End Property

    Property EmpSalary() As Double
        Get
            Return pEmpSalary
        End Get
        Set(value As Double)
            pEmpSalary = value
        End Set
    End Property

    Property LocationNumbers() As Long
        Get
            Return pLocationNumbers
        End Get
        Set(value As Long)
            pLocationNumbers = value
        End Set
    End Property

    Property LocationName() As Dictionary(Of String, String)
        Get
            Return pLocationName
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationName = value
        End Set
    End Property

    Property LocationDatBegin() As Dictionary(Of String, String)
        Get
            Return pLocationDatBegin
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationDatBegin = value
        End Set
    End Property

    Property LocationDatEnd() As Dictionary(Of String, String)
        Get
            Return pLocationDatEnd
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationDatEnd = value
        End Set
    End Property

    Property LocationRegionTeam() As Dictionary(Of String, String)
        Get
            Return pLocationRegionTeam
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationRegionTeam = value
        End Set
    End Property

    Property LocationNormalDays() As Dictionary(Of String, String)
        Get
            Return pLocationNormalDays
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationNormalDays = value
        End Set
    End Property
    Property LocationFridayDays() As Dictionary(Of String, String)
        Get
            Return pLocationFridayDays
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationFridayDays = value
        End Set
    End Property
    Property LocationDutyType() As Dictionary(Of String, String)
        Get
            Return pLocationDutyType
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationDutyType = value
        End Set
    End Property
    Property LocationEmpLocDate() As Dictionary(Of String, String)
        Get
            Return pLocationEmpLocDate
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationEmpLocDate = value
        End Set
    End Property
    Property LocationEmpJobType() As Dictionary(Of String, String)
        Get
            Return pLocationEmpJobType
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationEmpJobType = value
        End Set
    End Property
    Property LocationEmpContractHNormal() As Dictionary(Of String, String)
        Get
            Return pLocationEmpContractHNormal
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationEmpContractHNormal = value
        End Set
    End Property
    Property LocationEmpContractHFriday() As Dictionary(Of String, String)
        Get
            Return pLocationEmpContractHFriday
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationEmpContractHFriday = value
        End Set
    End Property
    Property LocationEmpWeeklyVacation() As Dictionary(Of String, String)
        Get
            Return pLocationEmpWeeklyVacation
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationEmpWeeklyVacation = value
        End Set
    End Property
    Property LocationEmpMonthlyFridayWork() As Dictionary(Of String, String)
        Get
            Return pLocationEmpMonthlyFridayWork
        End Get
        Set(value As Dictionary(Of String, String))
            pLocationEmpMonthlyFridayWork = value
        End Set
    End Property
    Property EmpFridayCount() As Dictionary(Of String, String)
        Get
            Return pEmpFridayCount
        End Get
        Set(value As Dictionary(Of String, String))
            pEmpFridayCount = value
        End Set
    End Property
    Public Function LocationFirst() As String
        Dim a As String
        a = pLocationName.Keys.First
        Return pLocationName.Item(a)
    End Function

    Public Function LocationLast() As String
        Dim a As String
        a = pLocationName.Keys.Last
        Return pLocationName.Item(a)
    End Function

    Public Function LocationEmpJobTypeFirst() As String
        Dim a As String
        a = pLocationEmpJobType.Keys.First
        Return pLocationEmpJobType.Item(a)
    End Function

    Public Function LocationEmpJobTypeFirstLast() As String
        Dim a As String
        a = pLocationEmpJobType.Keys.Last
        Return pLocationEmpJobType.Item(a)

    End Function

End Class
