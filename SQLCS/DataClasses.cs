namespace SQLCS
{
    class RoleData
    {
        int RoleID; string RoleName;

        public RoleData(int i, string rn)
        {
            RoleID = i;
            RoleName = rn;
        }

        public string GetTableName() { return "Role"; }
        
        public int GetRoleID() { return RoleID; }
        public string GetRoleName() { return RoleName; }
        
        public string GetAllDataString() { return $"{GetRoleID()}, {GetRoleName()}"; }
        public string[] GetAllDataStringList() { return [Convert.ToString(GetRoleID()), Convert.ToString(GetRoleName())]; }
    }
    
    class StaffData
    {
        int StaffID; int RoleID; string Name; string Email; string PhoneNum; DateOnly DateJoined; string Status;

        public StaffData(int i, int r, string n, string e, string ph, DateOnly dj, string s){
            StaffID = i;
            RoleID = r;
            Name = n;
            Email = e;
            PhoneNum = ph;
            DateJoined = dj;
            Status = s;}

        public string GetTableName() { return "Staff"; }
        
        public int GetStaffID() { return StaffID; }
        public int GetRoleID() { return RoleID; }
        public string GetName() { return Name; }
        public string GetEmail() { return Email; }
        public string GetPhoneNum() { return PhoneNum; }
        public DateOnly GetDateJoined() { return DateJoined; }
        public string GetStatus() { return Status; }
        
        public string GetAllDataString() { return $"{GetStaffID()}, {GetRoleID()}, {GetName()}, {GetEmail()}, {GetPhoneNum()}, {GetDateJoined()}, {GetStatus()}"; }
        public string[] GetAllDataStringList() { return [Convert.ToString(GetStaffID()), Convert.ToString(GetRoleID()), Convert.ToString(GetName()), Convert.ToString(GetEmail()), Convert.ToString(GetPhoneNum()), Convert.ToString(GetDateJoined()), Convert.ToString(GetStatus())]; }
    }
    
    class GenreData
    {
        int GenreID; string GenreName;

        public GenreData(int i, string gn)
        {
            GenreID = i;
            GenreName = gn;
        }

        public string GetTableName() { return "Genre"; }
        
        public int GetGenreID() { return GenreID; }
        public string GetGenreName() { return GenreName; }
        
        public string GetAllDataString() { return $"{GetGenreID()}, {GetGenreName()}"; }
        public string[] GetAllDataStringList() { return [Convert.ToString(GetGenreID()), Convert.ToString(GetGenreName())]; }
    }
    
    class PublisherData
    {
        int PublisherID; string Name;

        public PublisherData(int i, string n)
        {
            PublisherID = i;
            Name = n;
        }

        public string GetTableName() { return "Publisher"; }
        
        public int GetPublisherID() { return PublisherID; }
        public string GetName() { return Name; }
        
        public string GetAllDataString() { return $"{GetPublisherID()}, {GetName()}"; }
        public string[] GetAllDataStringList() { return [Convert.ToString(GetPublisherID()), Convert.ToString(GetName())]; }
    }
    
    class MasterAuthorData
    {
        int AuthorID; string Name;

        public MasterAuthorData(int i, string n)
        {
            AuthorID = i;
            Name = n;
        }

        public string GetTableName() { return "MasterAuthor"; }
        
        public int GetAuthorID() { return AuthorID; }
        public string GetName() { return Name; }
        
        public string GetAllDataString() { return $"{GetAuthorID()}, {GetName()}"; }
        public string[] GetAllDataStringList() { return [Convert.ToString(GetAuthorID()), Convert.ToString(GetName())]; }
    }
    
    class BookMasterData
    {
        int BookID; int AuthorID; int GenreID; int PublisherID; string Title; string ISBN;

        public BookMasterData(int i, int a, int g, int p, string t, string bin)
        {
            BookID = i;
            AuthorID = a;
            GenreID = g;
            PublisherID = p;
            Title = t;
            ISBN = bin;
        }

        public string GetTableName() { return "MasterBooks"; }
        
        public int GetBookID() { return BookID; }
        public int GetAuthorID() { return AuthorID; }
        public int GetGenreID() { return GenreID; }
        public int GetPublisherID() { return PublisherID; }
        public string GetTitle() { return Title; }
        public string GetISBN() { return ISBN; }
        
        public string GetAllDataString() { return $"{GetBookID()}, {GetAuthorID()}, {GetGenreID()}, {GetPublisherID()}, {GetTitle()}, {GetISBN()}"; }
        public string[] GetAllDataStringList() { return [Convert.ToString(GetBookID()), Convert.ToString(GetAuthorID()), Convert.ToString(GetGenreID()), Convert.ToString(GetPublisherID()), Convert.ToString(GetTitle()), Convert.ToString(GetISBN())]; }
    }
    
    class CopiesOfBookData
    {
        int CopyID; int BookID; string Barcode; bool Status;

        public CopiesOfBookData(int ci, int bi, string b, bool s)
        {
            CopyID = ci;
            BookID = bi;
            Barcode = b;
            Status = s;
        }

        public string GetTableName() { return "CopiesOfBook"; }
        
        public int GetCopyID() { return CopyID; }
        public int GetBookID() { return BookID; }
        public string GetBarcode() { return Barcode; }
        public bool GetStatus() { return Status; }
        
        public string GetAllDataString() { return $"{GetCopyID()}, {GetBookID()}, {GetBarcode()}, {GetStatus()}"; }
        public string[] GetAllDataStringList() { return [Convert.ToString(GetCopyID()), Convert.ToString(GetBookID()), Convert.ToString(GetBarcode()), Convert.ToString(GetStatus())]; }
    }
    
    class MembersData
    {
        int MemberID; string Name; string Email; string PhoneNum; DateOnly DOB; DateOnly DateJoined; DateOnly MembershipExpiry; string Status;

        public MembersData(int i, string n, string e, string ph, DateOnly dob, DateOnly dj, DateOnly me, string s)
        {
            MemberID = i;
            Name = n;
            Email = e;
            PhoneNum = ph;
            DOB = dob;
            DateJoined = dj;
            MembershipExpiry = me;
            Status = s;
        }

        public string GetTableName() { return "Members"; }
        
        public int GetMemberID() { return MemberID; }
        public string GetName() { return Name; }
        public string GetEmail() { return Email; }
        public string GetPhoneNum() { return PhoneNum; }
        public DateOnly GetDOB() { return DOB; }
        public DateOnly GetDateJoined() { return DateJoined; }
        public DateOnly GetMembershipExpiry() { return MembershipExpiry; }
        public string GetStatus() { return Status; }
        
        public string GetAllDataString() { return $"{GetMemberID()}, {GetName()}, {GetEmail()}, {GetPhoneNum()}, {GetDOB()}, {GetDateJoined()}, {GetMembershipExpiry()}, {GetStatus()}"; }
        public string[] GetAllDataStringList() { return [Convert.ToString(GetMemberID()), Convert.ToString(GetName()), Convert.ToString(GetEmail()), Convert.ToString(GetPhoneNum()), Convert.ToString(GetDOB()), Convert.ToString(GetDateJoined()), Convert.ToString(GetMembershipExpiry()), Convert.ToString(GetStatus())]; }
    }
    
    class LoansData
    {
        int LoanID; int CopyID; int MemberID; int IssuedByStaffID; DateOnly DateIssued; DateOnly DateDue; DateOnly? DateReturned;

        public LoansData(int li, int ci, int mi, int si, DateOnly di, DateOnly dd, DateOnly? dr)
        {
            LoanID = li;
            CopyID = ci;
            MemberID = mi;
            IssuedByStaffID = si;
            DateIssued = di;
            DateDue = dd;
            DateReturned = dr;
        }

        public string GetTableName() { return "Loans"; }
        
        public int GetLoanID() { return LoanID; }
        public int GetCopyID() { return CopyID; }
        public int GetMemberID() { return MemberID; }
        public int GetIssuedByStaffID() { return IssuedByStaffID; }
        public DateOnly GetDateIssued() { return DateIssued; }
        public DateOnly GetDateDue() { return DateDue; }
        public DateOnly? GetDateReturned() { return DateReturned; }
        
        public string GetAllDataString() { return $"{GetLoanID()}, {GetCopyID()}, {GetMemberID()}, {GetIssuedByStaffID()}, {GetDateIssued()}, {GetDateDue()}, {GetDateReturned()}"; }
        public string[] GetAllDataStringList() { return [Convert.ToString(GetLoanID()), Convert.ToString(GetCopyID()), Convert.ToString(GetMemberID()), Convert.ToString(GetIssuedByStaffID()), Convert.ToString(GetDateIssued()), Convert.ToString(GetDateDue()), Convert.ToString(GetDateReturned())]; }
    }
    
    class LocationData
    {
        int LocationID; int CopyID; int Floor; int Section; int ShelfUnit; int NumberAcross;

        public LocationData(int li, int ci, int f, int s, int su, int na)
        {
            LocationID = li;
            CopyID = ci;
            Floor = f;
            Section = s;
            ShelfUnit = su;
            NumberAcross = na;
        }

        public string GetTableName() { return "Location"; }
        
        public int GetLocationID() { return LocationID; }
        public int GetCopyID() { return CopyID; }
        public int GetFloor() { return Floor; }
        public int GetSection() { return Section; }
        public int GetShelfUnit() { return ShelfUnit; }
        public int GetNumberAcross() { return NumberAcross; }
        
        public string GetAllDataString() { return $"{GetLocationID()}, {GetCopyID()}, {GetFloor()}, {GetSection()}, {GetShelfUnit()}, {GetNumberAcross()}"; }
        public string[] GetAllDataStringList() { return [Convert.ToString(GetLocationID()), Convert.ToString(GetCopyID()), Convert.ToString(GetFloor()), Convert.ToString(GetSection()), Convert.ToString(GetShelfUnit()), Convert.ToString(GetNumberAcross())]; }
    }
    
    class ShiftsData
    {
        int ShiftID; int StaffID; DateOnly ShiftStartDate; TimeOnly TimeStart; DateOnly? ShiftEndDate; TimeOnly? TimeEnd;

        public ShiftsData(int si, int sti, DateOnly ssd, TimeOnly ts, DateOnly? sed, TimeOnly? te)
        {
            ShiftID = si;
            StaffID = sti;
            ShiftStartDate = ssd;
            TimeStart = ts;
            ShiftEndDate = sed;
            TimeEnd = te;
        }

        public string GetTableName() { return "Shifts"; }
        
        public int GetShiftID() { return ShiftID; }
        public int GetStaffID() { return StaffID; }
        public DateOnly GetShiftStartDate() { return ShiftStartDate; }
        public TimeOnly GetTimeStart() { return TimeStart; }
        public DateOnly? GetShiftEndDate() { return ShiftEndDate; }
        public TimeOnly? GetTimeEnd() { return TimeEnd; }
        
        public string GetAllDataString() { return $"{GetShiftID()}, {GetStaffID()}, {GetShiftStartDate()}, {GetTimeStart()}, {GetShiftEndDate()}, {GetTimeEnd()}"; }
        public string[] GetAllDataStringList() { return [Convert.ToString(GetShiftID()), Convert.ToString(GetStaffID()), Convert.ToString(GetShiftStartDate()), Convert.ToString(GetTimeStart()), Convert.ToString(GetShiftEndDate()), Convert.ToString(GetTimeEnd())]; }
    }
}