using FluentValidation;

public class DiretorInputPutDTO {
     public string Nome { get; set; }
}

public class DiretorInputPutDTOValidator : AbstractValidator<DiretorInputPutDTO> {
  public DiretorInputPutDTOValidator() {
    RuleFor(x => x.Nome)
      .NotEmpty()
      .WithMessage("O nome do diretor é obrigatorio");
  }
}