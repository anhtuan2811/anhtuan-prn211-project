using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class StudentManagementContext : DbContext
    {
        public StudentManagementContext()
        {
        }

        public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentExercise> StudentExercises { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherSubject> TeacherSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("MyConStr"));


#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                /* optionsBuilder.UseSqlServer("server=LAPTOP-MNORG9UG\\SQLEXPRESS; database = StudentManagement;uid=sa1;pwd=153264;");*/
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.ClassId)
                    .HasMaxLength(50)
                    .HasColumnName("ClassID");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MajorsId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MajorsID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Majors)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.MajorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Class_Majors");
            });

            modelBuilder.Entity<Exercise>(entity =>
            {
                entity.HasKey(e => e.ExerciseName);

                entity.ToTable("Exercise");

                entity.Property(e => e.ExerciseName).HasMaxLength(20);

                entity.Property(e => e.Percentage)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SubjectId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exercise_Subject");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("Login");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.HasKey(e => e.MajorsId);

                entity.Property(e => e.MajorsId)
                    .HasMaxLength(10)
                    .HasColumnName("MajorsID")
                    .IsFixedLength(true);

                entity.Property(e => e.MajorsName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(50)
                    .HasColumnName("StudentID");

                entity.Property(e => e.ClassId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ClassID");

                entity.Property(e => e.Dob)
                    .IsRequired()
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Class");
            });

            modelBuilder.Entity<StudentExercise>(entity =>
            {
                entity.HasKey(e => new { e.ExerciseName, e.StudentId });

                entity.ToTable("Student_Exercise");

                entity.Property(e => e.ExerciseName).HasMaxLength(20);

                entity.Property(e => e.StudentId)
                    .HasMaxLength(50)
                    .HasColumnName("StudentID");

                entity.Property(e => e.Marks)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.ExerciseNameNavigation)
                    .WithMany(p => p.StudentExercises)
                    .HasForeignKey(d => d.ExerciseName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Exercise_Exercise1");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentExercises)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Exercise_Student");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(10)
                    .HasColumnName("SubjectID");

                entity.Property(e => e.MajorsId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MajorsID")
                    .IsFixedLength(true);

                entity.Property(e => e.Semester)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Majors)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.MajorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subject_Majors");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");

                entity.Property(e => e.TeacherId)
                    .HasMaxLength(10)
                    .HasColumnName("TeacherID");

                entity.Property(e => e.Email).HasMaxLength(20);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TeacherSubject>(entity =>
            {
                entity.HasKey(e => new { e.TeacherId, e.SubjectId });

                entity.ToTable("Teacher_Subject");

                entity.Property(e => e.TeacherId)
                    .HasMaxLength(10)
                    .HasColumnName("TeacherID");

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(10)
                    .HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeacherSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Teacher_Subject_Subject");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherSubjects)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Teacher_Subject_Teacher");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
