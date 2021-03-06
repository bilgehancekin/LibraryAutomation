﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutuphane
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LocalDb")]
	public partial class kutuphaneDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertBookType(BookType instance);
    partial void UpdateBookType(BookType instance);
    partial void DeleteBookType(BookType instance);
    partial void InsertBorrow(Borrow instance);
    partial void UpdateBorrow(Borrow instance);
    partial void DeleteBorrow(Borrow instance);
    partial void InsertMember(Member instance);
    partial void UpdateMember(Member instance);
    partial void DeleteMember(Member instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertWriter(Writer instance);
    partial void UpdateWriter(Writer instance);
    partial void DeleteWriter(Writer instance);
    #endregion
		
		public kutuphaneDataContext() : 
				base(global::Kutuphane.Properties.Settings.Default.LocalDbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public kutuphaneDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public kutuphaneDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public kutuphaneDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public kutuphaneDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<BookType> BookTypes
		{
			get
			{
				return this.GetTable<BookType>();
			}
		}
		
		public System.Data.Linq.Table<Borrow> Borrows
		{
			get
			{
				return this.GetTable<Borrow>();
			}
		}
		
		public System.Data.Linq.Table<Member> Members
		{
			get
			{
				return this.GetTable<Member>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Writer> Writers
		{
			get
			{
				return this.GetTable<Writer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _ISBN;
		
		private string _Name;
		
		private int _PageNumber;
		
		private string _Publisher;
		
		private string _Summary;
		
		private float _Price;
		
		private System.Nullable<int> _WriterId;
		
		private System.Nullable<int> _TypeId;
		
		private EntitySet<Borrow> _Borrows;
		
		private EntityRef<BookType> _BookType;
		
		private EntityRef<Writer> _Writer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnISBNChanging(string value);
    partial void OnISBNChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPageNumberChanging(int value);
    partial void OnPageNumberChanged();
    partial void OnPublisherChanging(string value);
    partial void OnPublisherChanged();
    partial void OnSummaryChanging(string value);
    partial void OnSummaryChanged();
    partial void OnPriceChanging(float value);
    partial void OnPriceChanged();
    partial void OnWriterIdChanging(System.Nullable<int> value);
    partial void OnWriterIdChanged();
    partial void OnTypeIdChanging(System.Nullable<int> value);
    partial void OnTypeIdChanged();
    #endregion
		
		public Book()
		{
			this._Borrows = new EntitySet<Borrow>(new Action<Borrow>(this.attach_Borrows), new Action<Borrow>(this.detach_Borrows));
			this._BookType = default(EntityRef<BookType>);
			this._Writer = default(EntityRef<Writer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ISBN", DbType="NVarChar(MAX)")]
		public string ISBN
		{
			get
			{
				return this._ISBN;
			}
			set
			{
				if ((this._ISBN != value))
				{
					this.OnISBNChanging(value);
					this.SendPropertyChanging();
					this._ISBN = value;
					this.SendPropertyChanged("ISBN");
					this.OnISBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageNumber", DbType="Int NOT NULL")]
		public int PageNumber
		{
			get
			{
				return this._PageNumber;
			}
			set
			{
				if ((this._PageNumber != value))
				{
					this.OnPageNumberChanging(value);
					this.SendPropertyChanging();
					this._PageNumber = value;
					this.SendPropertyChanged("PageNumber");
					this.OnPageNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publisher", DbType="NVarChar(MAX)")]
		public string Publisher
		{
			get
			{
				return this._Publisher;
			}
			set
			{
				if ((this._Publisher != value))
				{
					this.OnPublisherChanging(value);
					this.SendPropertyChanging();
					this._Publisher = value;
					this.SendPropertyChanged("Publisher");
					this.OnPublisherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Summary", DbType="NVarChar(MAX)")]
		public string Summary
		{
			get
			{
				return this._Summary;
			}
			set
			{
				if ((this._Summary != value))
				{
					this.OnSummaryChanging(value);
					this.SendPropertyChanging();
					this._Summary = value;
					this.SendPropertyChanged("Summary");
					this.OnSummaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Real NOT NULL")]
		public float Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WriterId", DbType="Int")]
		public System.Nullable<int> WriterId
		{
			get
			{
				return this._WriterId;
			}
			set
			{
				if ((this._WriterId != value))
				{
					if (this._Writer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnWriterIdChanging(value);
					this.SendPropertyChanging();
					this._WriterId = value;
					this.SendPropertyChanged("WriterId");
					this.OnWriterIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeId", DbType="Int")]
		public System.Nullable<int> TypeId
		{
			get
			{
				return this._TypeId;
			}
			set
			{
				if ((this._TypeId != value))
				{
					if (this._BookType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTypeIdChanging(value);
					this.SendPropertyChanging();
					this._TypeId = value;
					this.SendPropertyChanged("TypeId");
					this.OnTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Borrow", Storage="_Borrows", ThisKey="Id", OtherKey="BookId")]
		public EntitySet<Borrow> Borrows
		{
			get
			{
				return this._Borrows;
			}
			set
			{
				this._Borrows.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BookType_Book", Storage="_BookType", ThisKey="TypeId", OtherKey="Id", IsForeignKey=true)]
		public BookType BookType
		{
			get
			{
				return this._BookType.Entity;
			}
			set
			{
				BookType previousValue = this._BookType.Entity;
				if (((previousValue != value) 
							|| (this._BookType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BookType.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._BookType.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._TypeId = value.Id;
					}
					else
					{
						this._TypeId = default(Nullable<int>);
					}
					this.SendPropertyChanged("BookType");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Writer_Book", Storage="_Writer", ThisKey="WriterId", OtherKey="Id", IsForeignKey=true)]
		public Writer Writer
		{
			get
			{
				return this._Writer.Entity;
			}
			set
			{
				Writer previousValue = this._Writer.Entity;
				if (((previousValue != value) 
							|| (this._Writer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Writer.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._Writer.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._WriterId = value.Id;
					}
					else
					{
						this._WriterId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Writer");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Borrows(Borrow entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_Borrows(Borrow entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookTypes")]
	public partial class BookType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Explanation;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnExplanationChanging(string value);
    partial void OnExplanationChanged();
    #endregion
		
		public BookType()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Explanation", DbType="NVarChar(MAX)")]
		public string Explanation
		{
			get
			{
				return this._Explanation;
			}
			set
			{
				if ((this._Explanation != value))
				{
					this.OnExplanationChanging(value);
					this.SendPropertyChanging();
					this._Explanation = value;
					this.SendPropertyChanged("Explanation");
					this.OnExplanationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BookType_Book", Storage="_Books", ThisKey="Id", OtherKey="TypeId")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.BookType = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.BookType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Borrows")]
	public partial class Borrow : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _BorrowDate;
		
		private System.DateTime _EstimatedReturnDate;
		
		private System.Nullable<System.DateTime> _ReturnDate;
		
		private System.Nullable<int> _BookId;
		
		private System.Nullable<int> _MemberId;
		
		private EntityRef<Book> _Book;
		
		private EntityRef<Member> _Member;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnBorrowDateChanging(System.DateTime value);
    partial void OnBorrowDateChanged();
    partial void OnEstimatedReturnDateChanging(System.DateTime value);
    partial void OnEstimatedReturnDateChanged();
    partial void OnReturnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnReturnDateChanged();
    partial void OnBookIdChanging(System.Nullable<int> value);
    partial void OnBookIdChanged();
    partial void OnMemberIdChanging(System.Nullable<int> value);
    partial void OnMemberIdChanged();
    #endregion
		
		public Borrow()
		{
			this._Book = default(EntityRef<Book>);
			this._Member = default(EntityRef<Member>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BorrowDate", DbType="DateTime NOT NULL")]
		public System.DateTime BorrowDate
		{
			get
			{
				return this._BorrowDate;
			}
			set
			{
				if ((this._BorrowDate != value))
				{
					this.OnBorrowDateChanging(value);
					this.SendPropertyChanging();
					this._BorrowDate = value;
					this.SendPropertyChanged("BorrowDate");
					this.OnBorrowDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EstimatedReturnDate", DbType="DateTime NOT NULL")]
		public System.DateTime EstimatedReturnDate
		{
			get
			{
				return this._EstimatedReturnDate;
			}
			set
			{
				if ((this._EstimatedReturnDate != value))
				{
					this.OnEstimatedReturnDateChanging(value);
					this.SendPropertyChanging();
					this._EstimatedReturnDate = value;
					this.SendPropertyChanged("EstimatedReturnDate");
					this.OnEstimatedReturnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReturnDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ReturnDate
		{
			get
			{
				return this._ReturnDate;
			}
			set
			{
				if ((this._ReturnDate != value))
				{
					this.OnReturnDateChanging(value);
					this.SendPropertyChanging();
					this._ReturnDate = value;
					this.SendPropertyChanged("ReturnDate");
					this.OnReturnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookId", DbType="Int")]
		public System.Nullable<int> BookId
		{
			get
			{
				return this._BookId;
			}
			set
			{
				if ((this._BookId != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookIdChanging(value);
					this.SendPropertyChanging();
					this._BookId = value;
					this.SendPropertyChanged("BookId");
					this.OnBookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberId", DbType="Int")]
		public System.Nullable<int> MemberId
		{
			get
			{
				return this._MemberId;
			}
			set
			{
				if ((this._MemberId != value))
				{
					if (this._Member.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMemberIdChanging(value);
					this.SendPropertyChanging();
					this._MemberId = value;
					this.SendPropertyChanged("MemberId");
					this.OnMemberIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Borrow", Storage="_Book", ThisKey="BookId", OtherKey="Id", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.Borrows.Remove(this);
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.Borrows.Add(this);
						this._BookId = value.Id;
					}
					else
					{
						this._BookId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Book");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_Borrow", Storage="_Member", ThisKey="MemberId", OtherKey="Id", IsForeignKey=true)]
		public Member Member
		{
			get
			{
				return this._Member.Entity;
			}
			set
			{
				Member previousValue = this._Member.Entity;
				if (((previousValue != value) 
							|| (this._Member.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Member.Entity = null;
						previousValue.Borrows.Remove(this);
					}
					this._Member.Entity = value;
					if ((value != null))
					{
						value.Borrows.Add(this);
						this._MemberId = value.Id;
					}
					else
					{
						this._MemberId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Member");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Members")]
	public partial class Member : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _SSN;
		
		private string _NameSurname;
		
		private System.DateTime _BirthDate;
		
		private System.DateTime _MembershipStartDate;
		
		private string _BirthPlace;
		
		private string _Adress;
		
		private string _TelephoneNumber;
		
		private string _EMail;
		
		private EntitySet<Borrow> _Borrows;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSSNChanging(string value);
    partial void OnSSNChanged();
    partial void OnNameSurnameChanging(string value);
    partial void OnNameSurnameChanged();
    partial void OnBirthDateChanging(System.DateTime value);
    partial void OnBirthDateChanged();
    partial void OnMembershipStartDateChanging(System.DateTime value);
    partial void OnMembershipStartDateChanged();
    partial void OnBirthPlaceChanging(string value);
    partial void OnBirthPlaceChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    partial void OnTelephoneNumberChanging(string value);
    partial void OnTelephoneNumberChanged();
    partial void OnEMailChanging(string value);
    partial void OnEMailChanged();
    #endregion
		
		public Member()
		{
			this._Borrows = new EntitySet<Borrow>(new Action<Borrow>(this.attach_Borrows), new Action<Borrow>(this.detach_Borrows));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SSN", DbType="NVarChar(MAX)")]
		public string SSN
		{
			get
			{
				return this._SSN;
			}
			set
			{
				if ((this._SSN != value))
				{
					this.OnSSNChanging(value);
					this.SendPropertyChanging();
					this._SSN = value;
					this.SendPropertyChanged("SSN");
					this.OnSSNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameSurname", DbType="NVarChar(MAX)")]
		public string NameSurname
		{
			get
			{
				return this._NameSurname;
			}
			set
			{
				if ((this._NameSurname != value))
				{
					this.OnNameSurnameChanging(value);
					this.SendPropertyChanging();
					this._NameSurname = value;
					this.SendPropertyChanged("NameSurname");
					this.OnNameSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDate", DbType="DateTime NOT NULL")]
		public System.DateTime BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this.OnBirthDateChanging(value);
					this.SendPropertyChanging();
					this._BirthDate = value;
					this.SendPropertyChanged("BirthDate");
					this.OnBirthDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MembershipStartDate", DbType="DateTime NOT NULL")]
		public System.DateTime MembershipStartDate
		{
			get
			{
				return this._MembershipStartDate;
			}
			set
			{
				if ((this._MembershipStartDate != value))
				{
					this.OnMembershipStartDateChanging(value);
					this.SendPropertyChanging();
					this._MembershipStartDate = value;
					this.SendPropertyChanged("MembershipStartDate");
					this.OnMembershipStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthPlace", DbType="NVarChar(MAX)")]
		public string BirthPlace
		{
			get
			{
				return this._BirthPlace;
			}
			set
			{
				if ((this._BirthPlace != value))
				{
					this.OnBirthPlaceChanging(value);
					this.SendPropertyChanging();
					this._BirthPlace = value;
					this.SendPropertyChanged("BirthPlace");
					this.OnBirthPlaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="NVarChar(MAX)")]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelephoneNumber", DbType="NVarChar(MAX)")]
		public string TelephoneNumber
		{
			get
			{
				return this._TelephoneNumber;
			}
			set
			{
				if ((this._TelephoneNumber != value))
				{
					this.OnTelephoneNumberChanging(value);
					this.SendPropertyChanging();
					this._TelephoneNumber = value;
					this.SendPropertyChanged("TelephoneNumber");
					this.OnTelephoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMail", DbType="NVarChar(MAX)")]
		public string EMail
		{
			get
			{
				return this._EMail;
			}
			set
			{
				if ((this._EMail != value))
				{
					this.OnEMailChanging(value);
					this.SendPropertyChanging();
					this._EMail = value;
					this.SendPropertyChanged("EMail");
					this.OnEMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_Borrow", Storage="_Borrows", ThisKey="Id", OtherKey="MemberId")]
		public EntitySet<Borrow> Borrows
		{
			get
			{
				return this._Borrows;
			}
			set
			{
				this._Borrows.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Borrows(Borrow entity)
		{
			this.SendPropertyChanging();
			entity.Member = this;
		}
		
		private void detach_Borrows(Borrow entity)
		{
			this.SendPropertyChanging();
			entity.Member = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Username;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(MAX)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(MAX)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Writers")]
	public partial class Writer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NameSurname;
		
		private System.DateTime _BirthDate;
		
		private string _Biography;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameSurnameChanging(string value);
    partial void OnNameSurnameChanged();
    partial void OnBirthDateChanging(System.DateTime value);
    partial void OnBirthDateChanged();
    partial void OnBiographyChanging(string value);
    partial void OnBiographyChanged();
    #endregion
		
		public Writer()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameSurname", DbType="NVarChar(MAX)")]
		public string NameSurname
		{
			get
			{
				return this._NameSurname;
			}
			set
			{
				if ((this._NameSurname != value))
				{
					this.OnNameSurnameChanging(value);
					this.SendPropertyChanging();
					this._NameSurname = value;
					this.SendPropertyChanged("NameSurname");
					this.OnNameSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDate", DbType="DateTime NOT NULL")]
		public System.DateTime BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this.OnBirthDateChanging(value);
					this.SendPropertyChanging();
					this._BirthDate = value;
					this.SendPropertyChanged("BirthDate");
					this.OnBirthDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Biography", DbType="NVarChar(MAX)")]
		public string Biography
		{
			get
			{
				return this._Biography;
			}
			set
			{
				if ((this._Biography != value))
				{
					this.OnBiographyChanging(value);
					this.SendPropertyChanging();
					this._Biography = value;
					this.SendPropertyChanged("Biography");
					this.OnBiographyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Writer_Book", Storage="_Books", ThisKey="Id", OtherKey="WriterId")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Writer = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Writer = null;
		}
	}
}
#pragma warning restore 1591
